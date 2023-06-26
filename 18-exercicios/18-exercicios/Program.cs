using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main()
        {
            /*Questao 1
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= input; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*Questao 2
            Console.Write("Insira a quantidade de valores: ");
            int input = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;

            for (int i = 0; i < input; i++)
            {
                int value = int.Parse(Console.ReadLine());
                
                if (value >= 10 && value <= 20)
                {
                    x++;
                }
                else
                {
                    y++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{x} in");
            Console.WriteLine($"{y} out");
            */

            /*Questao 3
            Console.Write("Insira a quantidade de casos: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < input; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                double n1 = double.Parse(data[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(data[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(data[2], CultureInfo.InvariantCulture);

                double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

                Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
            */

            /*Questao 4
            Console.Write("Insira a quantidade de casos: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < input; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                double n1 = double.Parse(data[0]);
                double n2 = double.Parse(data[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível");
                    Console.WriteLine();
                    continue;
                }

                double total = n1 / n2;

                Console.WriteLine(total.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
            */

            /*Questao 5
            Console.Write("Digite um número: ");
            int input = int.Parse(Console.ReadLine());
            int total = 1;

            for (int i = input; i >= 1; i--)
            {
                total *= i;
            }

            Console.WriteLine(total);
            */

            /*Questao 6
            Console.Write("Digite um número: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*Questao 7*/
            Console.Write("Digite um número: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}