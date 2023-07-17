namespace _75ExercicioInterfaces.Services
{
    internal interface ITaxService
    {
        public double MonthTax(double amount, int numInstallments);
        public double PaymentFee(double amount);
    }
}
