using _61ClassesAbstratas.Entities;
using System.Globalization;

namespace _61ClassesAbstratas
{
    class Program
    {
        static void Main()
        {
            //Account acc = new(1001, "Alex", 0);

            List<Account> accounts = new();

            accounts.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500, 400));
            accounts.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            accounts.Add(new BusinessAccount(1004, "Anna", 500, 500));

            double sum = 0;

            foreach (Account account in accounts)
            {
                sum += account.Balance;
            }

            Console.WriteLine(sum.ToString("f2", CultureInfo.InvariantCulture));

            foreach (Account acc in accounts)
            {
                acc.Withdraw(10);
            }

            foreach (Account acc in accounts)
            {
                Console.WriteLine($"Account {acc.Number} Balance: {acc.Balance}");
            }
        }
    }
}