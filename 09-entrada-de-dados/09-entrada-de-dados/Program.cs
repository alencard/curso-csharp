using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main()
        {
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] hello = Console.ReadLine().Split(' ');
            string item1 = hello[0];
            string item2 = hello[1];
            string item3 = hello[2];

            Console.WriteLine($"Você digitou \"{frase}\"");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"[ {item1}, {item2}, {item3} ]");
            */
            /*
            int num = int.Parse(Console.ReadLine());

            char gen = char.Parse(Console.ReadLine());

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(num);
            Console.WriteLine(gen);
            Console.WriteLine(price.ToString(CultureInfo.InvariantCulture));
            */
            /*
            string[] data = Console.ReadLine().Split(' ');

            string nome = data[0];
            char gen = char.Parse(data[1]);
            int idade = int.Parse(data[2]);
            double alt = double.Parse(data[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(gen);
            Console.WriteLine(idade);
            Console.WriteLine(alt.ToString(CultureInfo.InvariantCulture));
            */

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] data = Console.ReadLine().Split(' ');
            string lastName = data[0];
            int age = int.Parse(data[1]);
            double height = double.Parse(data[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(price.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString(CultureInfo.InvariantCulture));
        }
    }
}