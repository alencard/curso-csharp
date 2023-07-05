using System.Globalization;

namespace _48_datetime
{
    class Program
    {
        static void Main()
        {
            /*
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            */

            /*
            DateTime d1 = new(2023, 7, 4);
            DateTime d2 = new(2023, 7, 4, 16, 7, 33);
            DateTime d3 = new(2023, 7, 4, 16, 7, 33, 200);
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            */

            /*
            DateTime d1 = DateTime.Parse("2023-07-04 16:12:34");
            DateTime d2 = DateTime.Parse("04/07/2023 16:17:07");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            */

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("04/07/2023 16:20:15", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}