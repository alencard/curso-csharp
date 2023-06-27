using System.Globalization;

namespace _26_construtores
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto tv = new(nome, preco);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {tv}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            tv.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {tv}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            tv.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {tv}");
        }
    }
}