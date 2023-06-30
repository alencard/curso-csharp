using System.Globalization;

namespace _22_problema_exemplo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /*
        // essa situação não acontece, o padrao do c# não é camelcase
        public Produto(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }
        */

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            double quantity = Preco * Quantidade;

            return quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return $"{Nome}, R${Preco.ToString("f2", CultureInfo.InvariantCulture)}, {Quantidade} unidades. Total: R${ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}