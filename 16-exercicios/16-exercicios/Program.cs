using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main()
        {
            /*Execicio 1
            Console.Write("Insira a senha: ");
            int input = int.Parse(Console.ReadLine());

            while (input != 2002)
            {
                Console.WriteLine("Senha inválida");
                Console.WriteLine();
                Console.Write("Tente novamente: ");
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
            */

            /*Exercicio 2


            Console.Write("Insira os valores: ");
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            while (x != 0 && y != 0)
            {
                string quadrante;

                if (x > 0 && y > 0)
                {
                    quadrante = "primeiro";
                }
                else if (x < 0 && y > 0)
                {
                    quadrante = "segundo";
                }
                else if (x < 0 && y < 0)
                {
                    quadrante = "terceiro";
                }
                else
                {
                    quadrante = "quarto";
                }


                Console.WriteLine(quadrante);
                Console.WriteLine();

                Console.Write("Insira os valores: ");
                input = Console.ReadLine().Split(' ');
                x = int.Parse(input[0]);
                y = int.Parse(input[1]);
            }
            */

            /*Exercicio 3*/
            int index = 1;
            int alcool = 0;
            int gas = 0;
            int diesel = 0;

            while (index != 4)
            {
                Console.Write("Insira seu combustível: ");
                index = int.Parse(Console.ReadLine());

                if (index == 1)
                {
                    alcool++;
                }
                else if (index == 2)
                {
                    gas++;
                }
                else if (index == 3)
                {
                    diesel++;
                }
                else if (index == 4)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Insira um ID válido");
                    Console.WriteLine();
                    continue;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gas}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}