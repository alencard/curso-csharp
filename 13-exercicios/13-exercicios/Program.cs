using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main()
        {
            /*
            Exercicio 1
            int input = int.Parse(Console.ReadLine());

            if (input == 0) {
                Console.WriteLine("Neutro");
            }
            else if (input > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
            */

            /*
            Exercicio 2
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("Neutro");
            }
            else if (input % 2 == 0) {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }
            */

            /*Exercicio 3
            while (true)
            {
                string[] data = Console.ReadLine().Split(' ');

                int a = int.Parse(data[0]), b = int.Parse(data[1]);

                if (a == 0 || b == 0)
                {
                    Console.WriteLine("Impossível dividir por zero");
                }
                else if (a % b == 0 || b % a == 0)
                {
                    Console.WriteLine("São múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
                Console.WriteLine();
            }
            */

            /*Exercicio 4

            while (true)
            {
                string[] data = Console.ReadLine().Split(' ');

                int ent = int.Parse(data[0]), saida = int.Parse(data[1]);
                int calculo;

                if (ent > 24 || saida > 24)
                {
                    calculo = 0;
                    Console.WriteLine("Insira um valor válido.");
                }
                else if (ent == saida)
                {
                    calculo = 24;
                }
                else if (ent >= saida)
                {
                    calculo = 24 - ent + saida;
                }
                else
                {
                    calculo = saida - ent;
                }

                if (calculo != 0)
                {
                    Console.WriteLine($"O jogo durou {calculo} hora(s).");
                }

                Console.WriteLine();
            }
            */

            /*Exercicio 5

            while (true)
            {
                string[] data = Console.ReadLine().Split(' ');

                int id = int.Parse(data[0]), quant = int.Parse(data[1]);
                double price;

                if (id == 1) {
                    price = 4.0;
                }
                else if (id == 2)
                {
                    price = 4.5;
                }
                else if (id == 3)
                {
                    price = 5.0;
                }
                else if (id == 4)
                {
                    price = 2.0;
                }
                else if (id == 5)
                {
                    price = 1.5;
                }
                else
                {
                    price = 0;
                }

                double total = price * quant;

                Console.WriteLine($"Total: R${total.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
            }
            */

            /*Exercicio 6
            while (true)
            {
                double input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                string intervalo;

                if (input >= 0 && input < 25)
                {
                    intervalo = "(0, 24)";
                }
                else if (input >= 25 && input < 50)
                {
                    intervalo = "(25, 49)";
                }
                else if (input >= 50 && input < 75)
                {
                    intervalo = "(50, 74)";
                }
                else if (input >= 75 && input <= 100)
                {
                    intervalo = "(75, 100)";
                }
                else
                {
                    intervalo = "0";
                    Console.WriteLine("Fora dos intervalos");
                }

                if (intervalo != "0")
                {
                    Console.WriteLine($"Intervalo {intervalo}");
                }
            }
            */

            /*Exercicio 7
            while (true)
            {
                string[] data = Console.ReadLine().Split(' ');

                double x = double.Parse(data[0], CultureInfo.InvariantCulture);
                double y = double.Parse(data[1], CultureInfo.InvariantCulture);
                string quadrante;

                if (x > 0 && y > 0)
                {
                    quadrante = "Q1";
                }
                else if (x < 0 && y > 0) {
                    quadrante = "Q2";
                }
                else if (x < 0 && y < 0)
                {
                    quadrante = "Q3";
                }
                else if (x > 0 && y < 0)
                {
                    quadrante = "Q4";
                }
                else if (x == 0 && y == 0) {
                    quadrante = "Origem";
                }
                else {
                    quadrante = "Inderteminável";
                }

                Console.WriteLine(quadrante);
                Console.WriteLine();
            }
            */

            /*Exercicio 8*/
            while (true)
            {
                Console.WriteLine("Insira sua renda:");
                double input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double firstTax = 0.08, scndTax = 0.18, thirdTax = 0.28;
                double total;

                if (input > 4500.1)
                {
                    double firstQuota = 1000 * firstTax;
                    double scndQuota = 1500 * scndTax;
                    double thirdQuota = (input - 4500.0) * thirdTax;
                    total = firstQuota + scndQuota + thirdQuota;
                }
                else if (input < 4500.0 && input > 3000.01)
                {
                    double firstQuota = 1000 * firstTax;
                    double scndQuota = (input - 3000.0) * scndTax;
                    total = firstQuota + scndQuota;
                }
                else if (input < 3000.0 && input > 2000.01)
                {
                    total = (input - 2000.0) * firstTax;
                }
                else if (input < 2000 && input > 0)
                {
                    total = 0;
                }
                else
                {
                    Console.WriteLine("Insira um valor válido");
                    continue;
                }

                if (total != 0)
                {
                    Console.WriteLine($"R${total.ToString("f2", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine("Isento");
                }
                Console.WriteLine();
            }
        }
    }
}