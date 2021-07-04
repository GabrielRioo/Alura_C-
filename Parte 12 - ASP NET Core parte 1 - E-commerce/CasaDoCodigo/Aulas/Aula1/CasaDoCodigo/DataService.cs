using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void InicializaDb() // inicializa o banco de dados, se necessario
        {
            contexto.Database.Migrate();

            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);

            foreach (var item in livros)
            {
                contexto.Set<Produto>().Add(new Produto(item.Codigo, item.Nome, item.Preco)); // adiciona informações na memoria, e nao pro banco de dados.

            }
            contexto.SaveChanges(); // adiciona no banco de dados.
        }
    }

    class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
