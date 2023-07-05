namespace _51_timespan_prop
{
    class Program
    {
        static void Main()
        {
            /*
            TimeSpan t1 = TimeSpan.MaxValue;
            Console.WriteLine(t1);

            TimeSpan t2 = TimeSpan.MinValue;
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t3);
            */

            /*
            TimeSpan t = new(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            Console.WriteLine($"Days: {t.Days}");
            Console.WriteLine($"Hours: {t.Hours}");
            Console.WriteLine($"Minutes: {t.Minutes}");
            Console.WriteLine($"Seconds: {t.Seconds}");
            Console.WriteLine($"Milliseconds: {t.Milliseconds}");
            Console.WriteLine($"Ticks: {t.Ticks}");
            Console.WriteLine();
            Console.WriteLine($"TotalDays: {t.TotalDays}");
            Console.WriteLine($"TotalHours: {t.TotalHours}");
            Console.WriteLine($"TotalMinutes: {t.TotalMinutes}");
            Console.WriteLine($"TotalSeconds: {t.TotalSeconds}");
            Console.WriteLine($"TotalMilliseconds: {t.TotalMilliseconds}");
            */

            TimeSpan t1 = new(1, 30, 10);
            TimeSpan t2 = new(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            Console.WriteLine(sum);

            Console.WriteLine();
            TimeSpan diff = t1.Subtract(t2);
            Console.WriteLine(diff);

            Console.WriteLine();
            TimeSpan mult = t2.Multiply(2);
            Console.WriteLine(mult);

            Console.WriteLine();
            TimeSpan div = t2.Divide(5);
            Console.WriteLine(div);
        }
    }
}