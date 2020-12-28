using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriel = new ContaCorrente();
            contaGabriel.titular = "Gabriel";
            contaGabriel.agencia = 863;
            contaGabriel.numero = 863452;

            ContaCorrente contaGabrielSouza = new ContaCorrente();
            contaGabrielSouza.titular = "Gabriel";
            contaGabrielSouza.agencia = 863;
            contaGabrielSouza.numero = 863452;

            Console.WriteLine(contaGabriel == contaGabrielSouza);

        }
    }
}
