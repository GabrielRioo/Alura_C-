using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(976, 8654872);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //ContaCorrente.TotalDeContasCriadas = 1000;

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaGabriel = new ContaCorrente(976, 8654854);


            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        }
    }
}
