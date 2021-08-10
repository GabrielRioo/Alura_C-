using Caelum.Stella.CSharp.Validation;
using System;
using System.Diagnostics;

namespace ValidadorDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 86288366757
            // 98745366797
            // 22222222222

            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

        }

        private static void ValidarCPF(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Debug.WriteLine($"CPF valido: {cpf}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CPF invalido: {cpf} - {ex.Message}");
            }
        }
    }
}
