using _66ExercicioDeFixacao.Entities;
using _66ExercicioDeFixacao.Entities.Exceptions;
using System.Globalization;

namespace _66ExercicioDeFixacao
{
    class Program
    {
        static void Main()
        {
            try
            {
                Account acc;
                int number;
                string holder;
                double initialBalance;
                double withdrawLimit;
                double withdraw;

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc = new(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(withdraw);

                Console.WriteLine($"New Balance: {acc.Balance.ToString("f2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}