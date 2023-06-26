using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main()
        {
            /* 
            Exercicio 1
            Console.WriteLine("Insira os números a serem somados:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma é {soma}");
            */

            /* Exercicio 2 
            Console.WriteLine("Insira o raio do círculo:");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"A = {area.ToString("f4", CultureInfo.InvariantCulture)}");
            */

            /* 
            Exercicio 3 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine($"Diferença = {diferenca}");
            */

            /*
            Exercicio 4 
            int id = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double payPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hours * payPerHour;

            Console.WriteLine($"Number = {id}");
            Console.WriteLine($"Salary = U${salary.ToString("f2", CultureInfo.InvariantCulture)}");
            */

            /* 
            Exercicio 5 
            string[] data1 = Console.ReadLine().Split(' ');
            string[] data2 = Console.ReadLine().Split(' ');

            int id1 = int.Parse(data1[0]), quant1 = int.Parse(data1[1]);
            int id2 = int.Parse(data2[0]), quant2 = int.Parse(data2[1]);

            double price1 = double.Parse(data1[2], CultureInfo.InvariantCulture), price2 = double.Parse(data2[2], CultureInfo.InvariantCulture);

            double total = quant1 * price1 + quant2 * price2;

            Console.WriteLine($"Valor a pagar = R${total.ToString("f2", CultureInfo.InvariantCulture)}");
            */

            /* 
            Exercicio 6 */
            string[] data = Console.ReadLine().Split(' ');
            double a = double.Parse(data[0], CultureInfo.InvariantCulture);
            double b = double.Parse(data[1], CultureInfo.InvariantCulture);
            double c = double.Parse(data[2], CultureInfo.InvariantCulture);

            double triangleArea = (a * c) / 2;
            double circleArea = Math.PI * Math.Pow(c, 2);
            double trapezeArea = ((a + b) * c) / 2;
            double sqrArea = Math.Pow(b, 2);
            double rectArea = a * b;

            Console.WriteLine($"Triângulo: {triangleArea.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Círculo: {circleArea.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {trapezeArea.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {sqrArea.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {rectArea.ToString("f3", CultureInfo.InvariantCulture)}");
        }
    }
}