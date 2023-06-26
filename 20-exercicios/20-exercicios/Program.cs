using System.Globalization;

namespace _20_exercicios
{
    class Program
    {
        static void Main()
        {
            /* Questao 1
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade == y.Idade)
            {
                Console.WriteLine("Pessoa mais velha: Ambos tem a mesma idade");
            }
            else if (x.Idade > y.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {x.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {y.Nome}");
            }
            */

            /*Questao 2*/
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (x.Salary + y.Salary) / 2;

            Console.WriteLine($"Salário médio = {media.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}