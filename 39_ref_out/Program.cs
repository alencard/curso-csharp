namespace _39_ref_out
{
    class Program
    {
        static void Main()
        {
            /*
            int a = 10;
            // ref referencia a variavel na funcao, mudando seu valor original
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            */

            int a = 10;
            int result;
            // out faz algo semelhante mas não exige a variavel seja iniciada
            Calculator.Triple(a, out result);
            Console.WriteLine(result);
        }
    }
}
 