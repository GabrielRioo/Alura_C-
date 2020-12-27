using System;

namespace a12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calcula Poupança Longo Pazo");
            double fatorRendimento = 1.0036;
            double valorInvestido = 15000.0;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes < 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;

                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("O tempo de investiemeno foi de: " + valorInvestido);

            Console.WriteLine("Ao termino do investimento você terá: R$" + valorInvestido);
        }
    }
}
