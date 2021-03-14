using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriel = new Cliente();
            //gabriel.nome = "Gabriel";
            //gabriel.profissao = "Desenvolvedor C#";
            //gabriel.cpf = "123.123.123-12";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = gabriel;

            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriel";
            //conta.titular.profissao = "Desenvolvedor C#";
            //conta.titular.cpf = "123.123.123-12";


            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            //Console.WriteLine(gabriel.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);
        }
    }
}
