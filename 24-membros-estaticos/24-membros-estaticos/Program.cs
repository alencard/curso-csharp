using System.Globalization;

namespace _24_membros_estaticos
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insira o valor do raio: ");
            Circle.radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Circle.Circunferencia().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Circle.Volume().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Math.PI.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}