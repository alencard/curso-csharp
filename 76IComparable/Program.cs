using _76IComparable.Entities;

namespace _76IComparable
{
    class Program
    {
        static void Main()
        {
            List<Employee> list = new();
            string path = @"C:\Users\05357762252\Documents\cSharp\curso\76IComparable\docsParaTeste\employees.csv";

            try
            {
                using StreamReader sr = new(path);

                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }

                list.Sort();
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            foreach (Employee s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}