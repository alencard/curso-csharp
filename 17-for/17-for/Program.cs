namespace Course
{
    class Program
    {
        static void Main()
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int input = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < input; i++)
            {
                Console.Write($"Valor #{i}: ");
                int number = int.Parse(Console.ReadLine());
                total += number;
            }

            Console.WriteLine($"Soma = {total}");
        }
    }
}