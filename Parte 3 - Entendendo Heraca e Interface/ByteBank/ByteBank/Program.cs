using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("135.489.479-98");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("954.654.856-32");
            roberta.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("152.635.987-95");
            roberta.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificaçõees do mes: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
