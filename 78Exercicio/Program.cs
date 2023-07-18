using _78Exercicio.Services;
using _78Exercicio.Entities;

List<int> list = new();

Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    list.Add(x);
}

CalculationService<Product> calculation = new();