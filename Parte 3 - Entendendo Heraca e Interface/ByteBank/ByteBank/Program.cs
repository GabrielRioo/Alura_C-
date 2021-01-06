using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();



            Funcionario gabriel = new Funcionario();

            gabriel.Nome = "Gabriel";
            gabriel.CPF = "123.123.123-12";
            gabriel.Salario = 2000;

            gerenciador.Registrar(gabriel);

            Diretor camila = new Diretor();
            camila.Nome = "Camila";
            camila.CPF = "123.123.123-32";
            camila.Salario = 4000;

            Funcionario camilaTeste = camila;

            Console.WriteLine("Bonificação Diretor: " + camila.GetBonificacao());
            Console.WriteLine("Bonificação Funcionario: " + camilaTeste.GetBonificacao());

            gerenciador.Registrar(camila);

            Console.WriteLine(gabriel.Nome);
            Console.WriteLine(gabriel.GetBonificacao());

            Console.WriteLine(camila.Nome);
            Console.WriteLine(camila.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
        }
    }
}
