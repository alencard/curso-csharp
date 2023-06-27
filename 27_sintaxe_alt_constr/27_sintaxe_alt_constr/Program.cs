using System.Globalization;

namespace _27_sintaxe_alt_constr
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
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // funciona mesmo sem construtores implementados
            Produto tv = new() { 
                Nome = nome,
                Preco = preco,
                Quantidade = qtd
            };

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