using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(459, 46865);
            Console.WriteLine(conta.Saldo);
        }
    }
}
