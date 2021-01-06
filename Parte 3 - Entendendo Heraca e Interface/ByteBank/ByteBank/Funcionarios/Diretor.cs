using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
            
        }

        public override double GetBonificacao()
        {
            
            return Salario + base.GetBonificacao();
        }
    }
}
