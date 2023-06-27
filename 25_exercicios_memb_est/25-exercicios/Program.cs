using System.Globalization;

namespace _25_exercicios
{
    class Program
    {
        static void Main()
        {
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.CompraDolar(qtd).ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
