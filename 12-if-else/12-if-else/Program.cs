namespace Course
{
    class Program
    {
        static void Main()
        {
            /*
            int x = 10;

            Console.WriteLine("Bom dia");

            if (x < 10)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            if (x < 10)
            {
                Console.WriteLine("Hallo");
            }
            else if (x == 10)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Hillo");
            }
            */

            /*
            Console.WriteLine("Entre com um número inteiro: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("Zero é neutro");
            }
            else if (input % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }

            Console.WriteLine();
            */

            Console.WriteLine("Qual a hora atual?");
            int hour = int.Parse(Console.ReadLine());

            if (hour >= 24)
            {
                Console.WriteLine("Insira um horário válido");
            }
            else if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Boa Tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}