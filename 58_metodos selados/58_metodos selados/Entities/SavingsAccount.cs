namespace _58_metodos_selados.Entities
{
    /*sealed*/class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*
        //sobrescrevendo mudando o metodo
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
        */

        public sealed override void Withdraw(double amount)
        {
            //aproveito o metodo original
            base.Withdraw(amount);
            // e faço as alterações que preciso
            Balance -= 2;
        }
    }
}
