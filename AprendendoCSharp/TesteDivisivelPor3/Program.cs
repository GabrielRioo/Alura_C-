using System;

namespace TesteDivisivelPor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisivel por 3");

            for (int contador = 1; contador <= 100; contador++)
                if (contador % 3 == 0)
                    Console.WriteLine(contador);
        }
    }
}
