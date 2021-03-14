using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCamila = new ContaCorrente();
            contaCamila.titular = "Cammila";

            Console.WriteLine(contaCamila.saldo);
            bool resultadoSaque = contaCamila.Sacar(50);
            Console.WriteLine(contaCamila.saldo);
            Console.WriteLine(resultadoSaque);

            contaCamila.Depositar(500);
            Console.WriteLine(contaCamila.saldo);

            ContaCorrente contaGabriel = new ContaCorrente();

            contaGabriel.titular = "Gabriel";

            Console.WriteLine("Saldo da Camila: " + contaCamila.saldo);
            Console.WriteLine("Saldo da Gabriel: " + contaGabriel.saldo);

            contaCamila.Transferir(200, contaGabriel);

            bool resultadoTrans = contaCamila.Transferir(200, contaGabriel);

            Console.WriteLine(resultadoTrans);
            Console.WriteLine("Saldo da Camila: " + contaCamila.saldo);
            Console.WriteLine("Saldo da Gabriel: " + contaGabriel.saldo);


        }
    }
}
