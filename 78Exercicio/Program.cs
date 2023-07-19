using _78Exercicio.Services;
using _78Exercicio.Entities;
using System.Globalization;

try
{
    List<Product> list = new();

    Console.Write("Enter N: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        string[] data = Console.ReadLine().Split(',');
        string name = data[0];
        double price = double.Parse(data[1], CultureInfo.InvariantCulture);
        list.Add(new Product(name, price));
    }

    /*
    list.Sort();

    foreach (Product p in list)
    {
        Console.WriteLine(p);
    }
    */

    Console.Write("Most expensive: ");
    Console.WriteLine(CalculationService.Max(list));
}
catch (Exception e)
{
    Console.WriteLine($"ERROR: {e.Message}");
}