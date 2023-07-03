namespace _30_properties
{
    class Program
    {
        static void Main()
        {
            Produto p = new("TV", 500, 10);

            //a quantidade fica inacessivel por causa da sua proteção
            //p._quantidade = -10;
            //p._preco = 100

            //Console.WriteLine(p.GetNome());

            p.Nome = "Radio";
            p.Nome = "t";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            p.AdicionarProdutos(5);
            Console.WriteLine(p.Quantidade);
        }
    }
}