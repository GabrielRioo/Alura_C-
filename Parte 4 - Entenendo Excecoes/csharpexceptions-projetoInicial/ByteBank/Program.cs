using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(7480, 874150);
            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            try
            {
                Metodo();
            }
            catch (NullReferenceException erro)
            {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }
            
            Console.ReadLine();
            
        }

        

        private static void Metodo()
        {
                TestaDivisao(0);
                //TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {

            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possivel fazer uma divisão por 0");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }

    }
}
