using System.Globalization;

namespace _26_construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //sobrecarga
        public Produto()
        {

        }

        // construtor principal
        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        //sobrecarga
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
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