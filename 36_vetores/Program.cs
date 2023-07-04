using System.Globalization;

namespace _36_vetores
{
    class Program
    {
        static void Main()
        {
            /*
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double totalAlts = 0;

            for (int i = 0; i < vect.Length; i++)
            {
                double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = alt;
                totalAlts += alt; 
            }

            Console.WriteLine($"Average height: {(totalAlts / vect.Length).ToString("f2", CultureInfo.InvariantCulture)}");
            */

            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];
            double total = 0;

            for (int i = 0; i < vect.Length; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto p = new(nome, preco);
                vect[i] = p;
                total += p.Preco;
            }

            Console.WriteLine();
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine($"Valor total: R${total.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}