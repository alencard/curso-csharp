using _33_copy;

namespace _33_tipos
{
    class Program
    {
        static void Main()
        {
            /*
            int x = 10;
            // o valor sera copiado para y
            int y = x;

            y += 5;

            Console.WriteLine(x);
            Console.WriteLine(y);
            // caso o y seja alterado, a alteracao vai acontecer somente para ele


            Produto p = new(34, "Thiago", 500.00);
            Produto q = p;
            // em uma classe o valor não é copiado, é referenciado

            q.Id = 1;
            q.Nome = "Lucas";

            Console.WriteLine(p);
            Console.WriteLine(q);
            // quando um é alterado o outro tambem sofre alteracao
            */

            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new();

            Console.WriteLine(p);
        }
    }
}