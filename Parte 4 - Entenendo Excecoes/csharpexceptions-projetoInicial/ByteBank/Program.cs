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
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456,456789);
                ContaCorrente conta2 = new ContaCorrente(789,456123);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("InnerException: ");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
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
            //try
            //{
                int resultado = Dividir(10, divisor);

            //}
            //catch (Exception)
            //{
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            //}
        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero = " + numero + " e dividsor = " + divisor);
                throw;
            }
        }

    }
}
