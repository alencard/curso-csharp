namespace _50_datetime_prop
{
    class Program
    {
        static void Main()
        {
            /*
            DateTime d = new(2023, 7, 4, 16, 40, 27);

            Console.WriteLine(d);
            Console.WriteLine($"1 - Date: {d.Date}");
            Console.WriteLine($"2 - Day: {d.Day}");
            Console.WriteLine($"3 - DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4 - DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"5 - Hour: {d.Hour}");
            Console.WriteLine($"6 - Kind: {d.Kind}");
            Console.WriteLine($"7 - Millisecond: {d.Millisecond}");
            Console.WriteLine($"8 - Minute: {d.Minute}");
            Console.WriteLine($"9 - Month: {d.Month}");
            Console.WriteLine($"10 - Second: {d.Second}");
            Console.WriteLine($"11 - Ticks: {d.Ticks}");
            Console.WriteLine($"12 - TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13 - Year: {d.Year}");
            */

            /*
            DateTime d = new(2023, 7, 4, 16, 40, 27);

            Console.WriteLine(d.ToLongDateString());
            
            Console.WriteLine(d.ToLongTimeString());
            
            Console.WriteLine(d.ToShortDateString());
            
            Console.WriteLine(d.ToShortTimeString());
            
            Console.WriteLine(d.ToString());
            
            Console.WriteLine(d.ToString("yyyy-MM-dd hh:mm:ss tt"));
            
            Console.WriteLine(d.ToString("yyyy-MM-dd hh:mm:ss.fff tt"));
            */

            /*
            DateTime d = new(2023, 7, 4, 16, 40, 27);

            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d2);

            Console.WriteLine();
            DateTime d3 = d2.AddMinutes(25);
            Console.WriteLine(d3);

            Console.WriteLine();
            DateTime d4 = d3.AddDays(15);
            Console.WriteLine(d4);
            */

            DateTime d = new(2000, 10, 15);
            DateTime d2 = new(2000, 10, 18);

            TimeSpan t = d2.Subtract(d);
            Console.WriteLine(t);
        }
    }
}