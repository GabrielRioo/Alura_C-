﻿using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);
            builder.MapRoute("Livros/Lidos", LivrosLidos);
            builder.MapRoute("Livros/ParaLer", LivrosParaLer);
            builder.MapRoute("Livros/Lendo", LivrosLendo);
            builder.MapRoute("Livros/NovoLivro/{nome}/{autor}", NovoLivroParaLer); // rota com template usando dois seguimentos
            builder.MapRoute("Livros/Detalhes/{id:int}", ExibeDetalhes); // adicionando uma constraint, restrição de tipo.
            builder.MapRoute("Cadastro/NovoLivro", ExibeFormulario);
            builder.MapRoute("Cadastro/Incluir", ProcessaFormulario);

            var rotas = builder.Build();
            app.UseRouter(rotas);

            //app.Run(Roteamento);
        }

        private Task ProcessaFormulario(HttpContext context)
        {
            var livro = new Livro()
            {
                // pega o valor do query params "nome" e "autor"
                //Titulo = context.Request.Query["titulo"].First(),
                //Autor = context.Request.Query["autor"].First()

                Titulo = context.Request.Form["titulo"].First(),
                Autor = context.Request.Form["autor"].First()
            };

            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            return context.Response.WriteAsync("Livro foi adicionado com sucesso");
        }

        public Task ExibeFormulario(HttpContext context)
        {
            // action: especifica qual a rota cujo form vai ser enviado para processamento
            var html = CarregaArquivoHtml("formulario");
            return context.Response.WriteAsync(html);
        }

        public string CarregaArquivoHtml(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"HTML/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }

        public Task ExibeDetalhes(HttpContext context)
        {
            var id = Convert.ToInt32(context.GetRouteValue("id"));
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);

            return context.Response.WriteAsync(livro.Detalhes());
        }

        // adiciona um novo livro na lista de livros para ler
        public Task NovoLivroParaLer(HttpContext context)
        {
            var livro = new Livro()
            {
                // pega o valor do endpoint "nome" e "autor"
                Titulo = context.GetRouteValue("nome").ToString(),
                Autor = context.GetRouteValue("autor").ToString()
            };

            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            return context.Response.WriteAsync("Livro foi adicionado com sucesso");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(); // serviço de roteamento do asp net core.
        }


        // Roteamento mais rudimentar, usando dicionario.
        public Task Roteamento(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            var caminhosAtendidos = new Dictionary<string, RequestDelegate>
            {
                { "/Livros/ParaLer", LivrosParaLer },
                { "/Livros/Lendo", LivrosLendo },
                { "/Livros/Lidos", LivrosLidos }
            };

            if (caminhosAtendidos.ContainsKey(context.Request.Path))
            {
                var metodo = caminhosAtendidos[context.Request.Path];
                return metodo.Invoke(context);
            }

            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("Caminho inexistente.");
        }

        public Task LivrosParaLer(HttpContext context)
        {
            var conteudoArquivo = CarregaArquivoHtml("para-ler");
            var _repo = new LivroRepositorioCSV();

			foreach (var livro in _repo.ParaLer.Livros)
			{
                conteudoArquivo = conteudoArquivo.Replace("#NOVO-LIVRO#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-LIVRO#");
			}
            conteudoArquivo = conteudoArquivo.Replace("#NOVO-LIVRO#", "");

            return context.Response.WriteAsync(conteudoArquivo);
        }
        public Task LivrosLendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lendo.ToString());
        }

        public Task LivrosLidos(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lidos.ToString());
        }

    }
}