namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 1;
            Console.WriteLine(a);

            a *= 4;
            Console.WriteLine(a + "\n");

            string s = "abc";
            Console.WriteLine(s);

            s += "def";
            Console.WriteLine(s + "\n");

            int b = 10;
            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b + "\n");

            int c = 10;
            /*
            Console.WriteLine(c++);
            Console.WriteLine(c);
            */
            Console.WriteLine(++c);
            Console.WriteLine(c);
        }
    }
}
