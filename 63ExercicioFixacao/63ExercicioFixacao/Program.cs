using _63ExercicioFixacao.Entities;
using System.Globalization;

namespace _63ExercicioFixacao
{
    class Program
    {
        static void Main()
        {
            List<Contribuinte> contribuintes = new();
            int n;

            Console.Write("Enter the number of tax payers: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                char type;
                string name;
                double rendaAnual;

                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Anual income: ");
                rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    double HealthExpenses;

                    Console.Write("Health expenditures: ");
                    HealthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contribuintes.Add(new PessoaFisica(name, rendaAnual, HealthExpenses));
                    continue;
                }

                int qtdFuncionarios;

                Console.Write("Number of employees: ");
                qtdFuncionarios = int.Parse(Console.ReadLine());

                contribuintes.Add(new PessoaJuridica(name, rendaAnual, qtdFuncionarios));
            }

            double sum = 0;

            Console.WriteLine();
            Console.WriteLine("Taxes paid: ");
            foreach (Contribuinte contribuinte in contribuintes)
            {
                Console.WriteLine($"{contribuinte.Name}: R${contribuinte.Imposto().ToString("f2", CultureInfo.InvariantCulture)}");
                sum += contribuinte.Imposto();
            }

            Console.WriteLine();
            Console.WriteLine($"Total taxes: R${sum.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}