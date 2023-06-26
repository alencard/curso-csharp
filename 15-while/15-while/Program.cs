using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main()
        {
            double index = 0;

            while (index >= 0)
            {
                Console.Write("Digite um número: ");
                index = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (index >= 0) { 
                    Console.WriteLine(Math.Pow(index, 0.5).ToString("f3", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Número negativo");
                }
                Console.WriteLine();
            }
        }
    }
}
