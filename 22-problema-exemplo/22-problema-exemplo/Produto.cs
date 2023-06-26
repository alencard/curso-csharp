using System.Globalization;

namespace _22_problema_exemplo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
