using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_12___ASP_NET_Core_parte_1___E_commerce
{
    public class Livro
    {
        public Livro(string codigo, string nome, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

    }
}
