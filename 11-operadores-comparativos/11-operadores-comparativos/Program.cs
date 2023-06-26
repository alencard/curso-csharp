namespace Course
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            bool cond1 = a < 10;
            bool cond2 = a < 20;
            bool cond3 = a > 11;
            bool cond4 = a > 5;

            Console.WriteLine(cond1);
            Console.WriteLine(cond2);
            Console.WriteLine(cond3);
            Console.WriteLine(cond4);
            Console.WriteLine();

            bool cond5 = a <= 10;
            bool cond6 = a >= 10;
            bool cond7 = a == 10;
            bool cond8 = a != 10;

            Console.WriteLine(cond5);
            Console.WriteLine(cond6);
            Console.WriteLine(cond7);
            Console.WriteLine(cond8);
        }
    }
}