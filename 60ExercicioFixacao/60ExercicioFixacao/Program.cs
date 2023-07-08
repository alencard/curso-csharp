using _60ExercicioFixacao.Entities;
using System.Globalization;

namespace _60ExercicioFixacao
{
    class Program
    {
        static void Main()
        {
            List<Product> products = new();
            int n;

            Console.Write("Enter the number of products: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Product p;
                char type;
                string name;
                double price;

                Console.WriteLine();
                Console.WriteLine("Product #1 data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    double customFee;

                    Console.Write("Custom fee: ");
                    customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    p = new ImportedProduct(name, price, customFee);
                    products.Add(p);

                    continue;
                }

                if (type == 'u')
                {
                    DateTime date;

                    Console.Write("Manufacture date (dd/MM/yyyy): ");
                    date = DateTime.Parse(Console.ReadLine());

                    p = new UsedProduct(name, price, date);
                    products.Add(p);

                    continue;
                }

                p = new(name, price);
                products.Add(p);
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}