﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; set; }
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentantiva de saque do valor de: " + valorSaque + " em uma conta com saldo de: " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
