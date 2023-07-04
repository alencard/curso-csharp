using System.Globalization;

namespace _36_vetores
{
    class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome do produto: {Nome}, Preço: R${Preco.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
