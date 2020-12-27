using System;

namespace a10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 15000.0;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                //0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0016;
                Console.WriteLine(@"Apos {0} mes, voce tera R${1}",contadorMes, valorInvestido);

                contadorMes++;
            }

        }
    }
}
