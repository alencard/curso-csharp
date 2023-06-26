namespace Course
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite 3 números inteiros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine($"O maior é {resultado}");
            Console.WriteLine();
        }

        static int Maior(int a, int b, int c)
        {
            int maior;

            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
			else
            {
                maior = c;
            }

            return maior;
        }
    }
}