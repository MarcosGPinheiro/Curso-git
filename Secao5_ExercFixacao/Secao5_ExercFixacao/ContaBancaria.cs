
namespace Secao5_ExercFixacao
{
    class ContaBancaria
    {
        private readonly double TaxaSaque = 5.00;
        public string Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria(string conta, string nome, double deposito) : this(conta, nome)
        {
            Deposito(deposito);
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo = Saldo - valorSaque - TaxaSaque;
        }

        public override string ToString()
        {
            return $"Conta {Conta}, Titula: {Nome}, Saldo: {Saldo:C2} ";
        }
    }
}
