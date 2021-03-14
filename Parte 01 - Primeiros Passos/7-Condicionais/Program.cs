using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escutando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine(@"A idade de joão é: {0}, tem mais que 18 anos", idadeJoao);
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Jão nao possui mais que 18 anos, mas está acompanhado, pode entrar.");
                }
                else
                {
                    Console.WriteLine(@"A idade de joão é: {0}, não tem mais que 18 anos", idadeJoao);
                }
            }




        }
    }
}
