using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array de inteiros com 5 posições
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 21;
            idades[2] = 51;
            idades[3] = 84;
            idades[4] = 76;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idades}");

                acumulador += idade;

            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Media de idades = {media}");
            //Console.WriteLine(idades[4]);

            Console.ReadLine();
        }
    }
}
