using System.Globalization;

namespace _32_exercicios
{
    class Program
    {
        static void Main()
        {

            Console.Write("Entre com o número da conta: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Haverá deposito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());
            
            ContaBanco alex = new(id, nome);

            if (escolha == 's')
            {
                Console.Write("Insira o valor a ser depositado: R$ ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                alex = new(id, nome, valor);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(alex);

            Console.WriteLine();
            Console.Write("Insira um valor para depositar: R$ ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alex.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(alex);

            Console.WriteLine();
            Console.Write("Insira um valor para sacar: R$ ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alex.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(alex);
        }
    }
}