namespace _34_desalocacao
{
    class Program
    {
        static void Main()
        {
            /*garbage collector*/
            Produto p1, p2;

            p1 = new(23, "Hallo", 500);
            p2 = new(3, "Hello", 350);

            p1 = p2;
            // os valores atribuidos a p1 vao ser desalocadas pelo garbage collector

            Console.WriteLine(p1);


            /*desalocacao por escopo*/
            int x = 10;

            if (x > 0)
            {
                int y = 20;
            }

            Console.WriteLine(x);
            // quando o escopo é alcancado a variavel é inicializada, mas quando o escopo acaba ela é desalocada
        }
    }
}