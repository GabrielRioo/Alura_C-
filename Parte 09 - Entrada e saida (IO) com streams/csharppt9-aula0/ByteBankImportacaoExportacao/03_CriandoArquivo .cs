using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,6546,656.60,Gabriel Rio";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }

        }

        static void CriarArquivoComWriter()
        {
            var caminhoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,123654,789.65,Gabriel Rio");
            }

        }

        static void Exercicio01()
        {
            var arquivoOriginal = new FileStream("teste.txt", FileMode.Open);
            var arquivoNovo = new FileStream("teste_copia.txt", FileMode.Create);
            var buffer = new byte[1024];

            using (arquivoOriginal)
            using (arquivoNovo)
            {
                var bytesLidos = -1;
                while (bytesLidos != 0)
                {
                    bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
                    arquivoNovo.Write(buffer, 0, bytesLidos);
                }
            }

            var rodape = Encoding.UTF8.GetBytes("Este documento é uma cópia do original");
            arquivoNovo.Write(rodape, 0, rodape.Length);
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoArquivo))
            {
                for (int i = 0; i < 100; i++)
                {
                    escritor.Write($"Linha {i}");
                    escritor.Flush();
                }
            }
        }

    }


}
