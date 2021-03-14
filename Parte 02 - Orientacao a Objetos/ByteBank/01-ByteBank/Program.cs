using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaGabriel = new ContaCorrente();

            contaGabriel.titular = "Gabriel";
            contaGabriel.agencia = 863;
            contaGabriel.numero = 863452;
            contaGabriel.saldo = 100.0;

            Console.WriteLine("Titulo: " + contaGabriel.titular);
            Console.WriteLine("Agencia: " + contaGabriel.agencia);
            Console.WriteLine("Conta: " + contaGabriel.numero);
            Console.WriteLine("Saldo: " + contaGabriel.saldo);
        }
    }
}
