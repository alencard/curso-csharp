namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;

            double n4 = 10.0 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            */

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2) - 4.0 * a * c;

            double resultX1 = (-b + Math.Pow(delta, 0.5)) / (2 * a), resultX2 = (-b - Math.Pow(delta, 0.5)) / (2 * a);

            Console.WriteLine($"Resultados: x1 = {resultX1}, x2 = {resultX2}");
        }
    }
}