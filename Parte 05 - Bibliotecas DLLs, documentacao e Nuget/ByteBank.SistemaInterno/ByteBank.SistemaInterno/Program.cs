using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021,2 , 1);
            DateTime dataAtual = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataAtual; // intervalo de tempo
            TimeSpan diferenca2 = TimeSpan.FromMinutes(60); ; 

            //string mensagem = "Vencimento em: " + GetIntervaloDeTempoLegivel(diferenca);
            string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataAtual);
            Console.WriteLine(mensagem);
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if (quantidadeMeses == 1)
                {
                    return quantidadeMeses + " mes";
                }
                return quantidadeMeses + " meses";
            }
            return timeSpan.Days + " dias";
        }
    }
}
