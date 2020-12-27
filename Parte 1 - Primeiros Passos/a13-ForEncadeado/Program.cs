using System;

namespace a13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - For Encadeado");

            string asterisco = "*";

            //Forma diferente de fazer o desenho dos asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                Console.WriteLine(asterisco);
                asterisco = asterisco + "*";
            }

            //Escrevendo asterisco com o BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");

                    if (contadorColuna == contadorLinha)
                        break;
                }
                Console.WriteLine();
            }

            //Forma diferente de fazer o desenho dos asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
