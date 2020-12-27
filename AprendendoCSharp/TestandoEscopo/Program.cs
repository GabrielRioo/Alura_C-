using System;

namespace TestandoEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Escopo");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado = true;

            if (quantidadePessoas >= 2)
            {
                bool acompanhado = true;
            }
            else
            {
                bool acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }
        }
    }
}
