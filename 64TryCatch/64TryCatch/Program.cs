namespace _64TryCatch
{
    class Program
    {
        static void Main()
        {
            int n1;
            int n2;
            int result;

            try
            {
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());

                result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Division by zero is not allowed!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed!");
            }
        }
    }
}