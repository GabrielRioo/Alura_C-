using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Exercicios
{
    public class MaiorNumero
    {
        // SobreCarga utilizando o proprio metodo.
        public double Maior(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        public double Maior(double a, double b, double c)
        {
            return Maior(Maior(a, b), c);
        }
    }
}
