using System;
using ByteBank.Funcionarios;
using ByteBank.Sisitemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("135.489.479-98");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");
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

            Funcionario gabriel = new Desenvolvedor("833.222.048-39");
            pedro.Nome = "Gabriel";

            gerenciadorBonificacao.Registrar(gabriel);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificaçõees do mes: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
