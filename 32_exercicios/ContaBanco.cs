using System.Globalization;

namespace _32_exercicios
{
    internal class ContaBanco
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public ContaBanco(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public ContaBanco(int id, string nome, double depositoInicial) : this(id, nome)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            int tax = 5;
            Saldo -= (valor + tax);
        }

        public override string ToString()
        {
            return $"Conta {Id}, Titular: {Nome}, Saldo: R${Saldo.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}