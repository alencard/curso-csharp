using _66ExercicioDeFixacao.Entities.Exceptions;

namespace _66ExercicioDeFixacao.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount is bigger than the withdraw limit.");
            }

            if (Balance < amount)
            {
                throw new DomainException("The amount is bigger than the account balance.");
            }

            Balance -= amount;
        }
    }
}
