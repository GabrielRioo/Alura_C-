using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();



            Funcionario gabriel = new Funcionario(2000, "123.123.123-12");

            gabriel.Nome = "Gabriel";
            //gabriel.CPF = "123.123.123-12";

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            gabriel.AumentarSalario();
            Console.WriteLine("Novo Salario do Gabriel é : " + gabriel.Salario);
            gerenciador.Registrar(gabriel);

            Diretor camila = new Diretor("123.123.123-32");
            camila.Nome = "Camila";
            //camila.CPF = "123.123.123-32";

            Console.WriteLine(Funcionario.TotalDeFuncionarios);


            Funcionario camilaTeste = camila;
            camila.AumentarSalario();
            Console.WriteLine("Novo salario de Camila é: " + camila.Salario);

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
