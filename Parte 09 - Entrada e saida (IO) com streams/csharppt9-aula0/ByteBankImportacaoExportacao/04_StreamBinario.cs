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
        static void EscreverBinario()
        {
            using (var fs = new FileStream("testeBinario.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);
                escritor.Write(456123);
                escritor.Write(456.45);
                escritor.Write("Gabriel Rio");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("testeBinario.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var tirular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} - {tirular}, {saldo}");
            }
        }  
    }
}
