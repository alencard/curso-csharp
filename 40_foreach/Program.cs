namespace _40_foreach
{
    class Program
    {
        static void Main()
        {
            string[] vect = { "Maria", "Bob", "Alex" };

            foreach (var ve in vect)
            {
                Console.WriteLine(ve);
            }
        }
    }
}