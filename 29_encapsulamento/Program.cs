namespace _29_encapsulamento
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

            p.SetNome("t");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}