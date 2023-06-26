using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char gen = 'f';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("--------------");
            Console.WriteLine(gen);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            // ToString("F2") arredonda um numero com casas decimais
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(saldo.ToString(CultureInfo.InvariantCulture));
            */

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // placeholder
            Console.WriteLine("{0} tem {1} anos e tem o saldo de R${2:F2}", nome, idade, saldo);
            // Console.WriteLine("{0} tem {1} anos e tem o saldo de R${2}");

            // interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo de R${saldo:F2}");

            // concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo de R$" + saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

