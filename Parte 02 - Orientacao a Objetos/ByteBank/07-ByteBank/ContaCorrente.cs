//using _06_ByteBank;


namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        //public static int ObterTotalDeContasCriadas()
        //{
        //    return TotalDeContasCriadas;
        //}


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        } 
        public int Numero { get; set; }

        private double _saldo = 100.0;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        //public void DefinirSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }
        //    this.saldo = saldo;

        //}

        //public double ObterSaldo()
        //{
        //    return saldo;
        //}

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotalDeContasCriadas++; // quando esta dentro da classe, manipulando memmbros staticos, nao precisa colocar o nome da classe
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}