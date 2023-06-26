using System.Globalization;

namespace _22_problema_exemplo
{
    class Program
    {
        static void Main()
        {

            Produto tv = new();

            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            tv.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            tv.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            tv.Quantidade = int.Parse(Console.ReadLine());

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