namespace _75ExercicioInterfaces.Services
{
    internal class PaypalTax : ITaxService
    {
        public double MonthTax()
        {
            return 0;
        }

        public double PaymentFee()
        {
            return 0.02;
        }
    }
}
