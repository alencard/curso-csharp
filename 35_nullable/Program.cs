namespace _35_nullable
{
    class Program
    {
        static void Main()
        {
            /*
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            // ocorrera um erro pois x nao tem valor
            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);

            // condicao alcanca o else pois null é falsy
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
            */

            /*
            double? x = null;
            double y = x ?? 0;
            // quero copiar o valor de x para y, mas caso o x seja null o valor será zero
            */

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}