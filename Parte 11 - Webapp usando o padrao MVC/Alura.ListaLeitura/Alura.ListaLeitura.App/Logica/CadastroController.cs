using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
	public class CadastroController
	{
		// adiciona um novo livro na lista de livros para ler
		public string Incluir(Livro livro)
		{
			//var livro = new Livro()
			//{
			//	// pega o valor do query params "nome" e "autor"
			//	//Titulo = context.Request.Query["titulo"].First(),
			//	//Autor = context.Request.Query["autor"].First()

			//	Titulo = context.Request.Form["titulo"].First(),
			//	Autor = context.Request.Form["autor"].First()
			//};

			var repo = new LivroRepositorioCSV();
			repo.Incluir(livro);

			return "Livro foi adicionado com sucesso";
		}

		public static Task ExibeFormulario(HttpContext context)
		{
			// action: especifica qual a rota cujo form vai ser enviado para processamento
			var html = HtmlUtils.CarregaArquivoHtml("formulario");
			return context.Response.WriteAsync(html);
		}

		// adiciona um novo livro na lista de livros para ler
		//public string NovoLivro(Livro livro)
		//{
		//	//var livro = new Livro()
		//	//{
		//	//	// pega o valor do endpoint "nome" e "autor"
		//	//	Titulo = context.GetRouteValue("nome").ToString(),
		//	//	Autor = context.GetRouteValue("autor").ToString()
		//	//};

		//	var repo = new LivroRepositorioCSV();
		//	repo.Incluir(livro);

		//	return "Livro foi adicionado com sucesso";
		//}

		
	}
}
