using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escutando projeto 8 - Condicionais");

            int idadeJoao = 16;
            //int quantidadePessoas = 2;

            bool acompanhado = true;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine(@"Joao pode entrar!");
            }
            else
            {
                Console.WriteLine(@"Joao nao pode entrar");
            }
        }
    }
}
