using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario; //  cast

            Console.WriteLine(salarioEmInteiro);

            long idade = 1300000000000;

            short quantidadeProdutos = 20000;

            float altura = 1.80f;
        }
    }
}
