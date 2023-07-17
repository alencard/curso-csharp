namespace _75ExercicioInterfaces.Services
{
    internal class PaypalTax : ITaxService
    {
        private const double FeePorcentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double MonthTax(double amount, int numInstallments)
        {
            return amount * MonthlyInterest * numInstallments;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePorcentage;
        }
    }
}
