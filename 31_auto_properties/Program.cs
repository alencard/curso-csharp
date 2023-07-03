namespace _31_auto_properties
{
    class Program
    {
        static void Main()
        {
            Produto produto = new("TV", 500.00, 10);

            Console.WriteLine(produto.Preco);
        }
    }
}