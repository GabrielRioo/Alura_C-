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
                ContaCorrente conta = new ContaCorrente(456,456789);
                ContaCorrente conta2 = new ContaCorrente(453, 456783);

                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(-500);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo Saldo Insuficiente Exception");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            try
            {
                Metodo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
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
