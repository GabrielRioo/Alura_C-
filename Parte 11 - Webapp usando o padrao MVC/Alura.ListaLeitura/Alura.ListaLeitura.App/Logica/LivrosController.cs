using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
	{
        public IEnumerable<Livro> Livros { get; set; }
        public string Detalhes(int id)
		{
			var repo = new LivroRepositorioCSV();
			var livro = repo.Todos.First(l => l.Id == id);

			return livro.Detalhes();
		}

		public static string CarregaLista(IEnumerable<Livro> livros)
		{
			var conteudoArquivo = HtmlUtils.CarregaArquivoHtml("para-ler");
			
			return conteudoArquivo.Replace("#NOVO-LIVRO#", "");
		}

		public IActionResult Lidos()
		{
			var _repo = new LivroRepositorioCSV();
			ViewBag.Livros = _repo.Lidos.Livros;

			//var html = new ViewResult { ViewName = "" };
			//var html = CarregaLista(_repo.ParaLer.Livros);

			return View("lista");
		}
		public IActionResult Lendo()
		{
			var _repo = new LivroRepositorioCSV();
			ViewBag.Livros = _repo.Lendo.Livros;

			//var html = new ViewResult { ViewName = "lista" };

			return View("lista");
		}

		public IActionResult ParaLer()
		{
			var _repo = new LivroRepositorioCSV();
			ViewBag.Livros = _repo.ParaLer.Livros;

			//var html = new ViewResult { ViewName = "lista" };
			return View("lista");
		}

		public string Teste()
		{
			return "nova funcionalidade implementada!";
		}
	}
}
