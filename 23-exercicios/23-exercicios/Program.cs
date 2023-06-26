using System.Globalization;

namespace _23_exercicios
{
    class Program
    {
        static void Main()
        {
            /*Exercicio 1
            Retangulo rect = new();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            rect.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rect.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área = {rect.Area().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {rect.Perimetro().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {rect.Diagonal().ToString("f2", CultureInfo.InvariantCulture)}");
            */

            /*Exercicio 2
            Funcionario f1 = new();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {f1}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f1.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f1}");
            */

            /*Exercicio 3*/
            Aluno aluno1 = new();

            Console.Write("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Nota Final = {aluno1.NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}");

            aluno1.SituacaoFinal();
        }
    }
}

