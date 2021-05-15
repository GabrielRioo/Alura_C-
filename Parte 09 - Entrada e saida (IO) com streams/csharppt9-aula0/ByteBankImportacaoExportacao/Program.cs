using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Escrever na tela
            File.WriteAllText("escrevendo.txt", "Olá mundo");
            Console.WriteLine("arquivvo escrevendo.txt criado");

            //Le todas as linhas como bytes
            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo pussui {bytesArquivo.Length} bytes");

            // quando o arquivo possui poucas linhas. Le toddas as linhas
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var item in linhas)
            {
                Console.WriteLine(item);
            }
            //UsarStreamDeEntrada();
            Console.ReadLine();
        }


    }
}
