namespace _49_timespan
{
    class Program
    {
        static void Main()
        {
            /*
            TimeSpan t1 = new(240, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();
            TimeSpan t2 = new();
            Console.WriteLine(t2);

            Console.WriteLine();
            TimeSpan t3 = new(900000000L);
            Console.WriteLine(t3);

            Console.WriteLine();
            TimeSpan t4 = new(10, 16, 26, 47);
            Console.WriteLine(t4);

            Console.WriteLine();
            TimeSpan t5 = new(50, 20, 24, 52, 456);
            Console.WriteLine(t5);
            */

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t1);

            Console.WriteLine();
            TimeSpan t2 = TimeSpan.FromHours(1.75);
            Console.WriteLine(t2);

            Console.WriteLine();
            TimeSpan t3 = TimeSpan.FromMinutes(120);
            Console.WriteLine(t3);

            Console.WriteLine();
            TimeSpan t4 = TimeSpan.FromSeconds(360);
            Console.WriteLine(t4);
        }
    }
}