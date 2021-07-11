using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //// compra de 6 paes franceses
            //var paoFrances = new Produto();
            //paoFrances.Nome = "Pão Frances";
            //paoFrances.Preco_Unitario = 0.40;
            //paoFrances.Unidade = "Unidade";
            //paoFrances.Categoria = "Padaria";

            //var compra = new Compra();
            //compra.Quantidade = 6;
            //compra.Produto = paoFrances;
            //compra.Preco = paoFrances.Preco_Unitario * compra.Quantidade;

            var p1 = new Produto() { 
                Nome = "Suco de Laranja", 
                Categoria = "Bebidas", 
                Preco_Unitario = 8.79,
                Unidade = "Litros"
            };
            var p2 = new Produto() {
                Nome = "Café",
                Categoria = "Bebidas",
                Preco_Unitario = 12.45,
                Unidade = "Gramas"
            };
            var p3 = new Produto() {
                Nome = "Macarrao",
                Categoria = "Alimentos",
                Preco_Unitario = 4.23,
                Unidade = "Granas"
            };

            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                contexto.Promocoes.Add(promocaoDePascoa);
                contexto.SaveChanges();
            }
        }
    }
}
