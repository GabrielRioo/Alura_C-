using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escutando projeto 9 - Escopo");

            int idadeJoao = 19;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
                mensagemAdicional = "Joao está acompanhado!";
            else
                mensagemAdicional = "João nao está acompanhado";


            if (idadeJoao >= 18 || acompanhado == true)
                Console.WriteLine(@"Joao pode entrar! {0}", mensagemAdicional);
            else
                Console.WriteLine(@"Joao nao pode entrar! {0}", mensagemAdicional);
        }
    }
}
