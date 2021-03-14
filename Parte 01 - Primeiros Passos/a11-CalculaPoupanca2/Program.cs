using System;

namespace a11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança 2");

            double valoInvestido = 1000.0;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valoInvestido *=  1.0036;
                Console.WriteLine(@"Após {0} meses, você terá R${1}", contadorMes, valoInvestido);
            }

        }
    }
}
