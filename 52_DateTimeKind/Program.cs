namespace _52_DateTimeKind
{
    class Program
    {
        static void Main()
        {
            /*
            DateTime d1 = new(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new(2000, 8, 15, 13, 5, 58);

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d1 Kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC: {d1.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d2 Kind: {d2.Kind}");
            Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to UTC: {d2.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine($"d3: {d3}");
            Console.WriteLine($"d3 Kind: {d3.Kind}");
            Console.WriteLine($"d3 to Local: {d3.ToLocalTime()}");
            Console.WriteLine($"d3 to UTC: {d3.ToUniversalTime()}");
            */

            DateTime d1 = DateTime.Parse("2020-11-13 21:45:12");
            Console.WriteLine(d1);

            Console.WriteLine();
            DateTime d2 = DateTime.Parse("2020-11-13T21:45:12Z");
            Console.WriteLine(d2);

            Console.WriteLine();
            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d1 Kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC: {d1.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d2 Kind: {d2.Kind}");
            Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to UTC: {d2.ToUniversalTime()}");
        }
    }
}