namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double x;
            int y;

            x = 4.7;
            y = (int)x;

            Console.WriteLine(y);
            */

            int a = 5;
            int b = 2;

            // podemos colocar casting para fazer a conversao de tipos em outros tipos, isso pode ocasionar perda de informação
            double result = (double)a / b;

            Console.WriteLine(result);
        }
    }
}
