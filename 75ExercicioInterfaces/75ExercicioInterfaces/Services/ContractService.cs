using _75ExercicioInterfaces.Entities;

namespace _75ExercicioInterfaces.Services
{
    internal class ContractService
    {
        private readonly ITaxService _taxService;

        public ContractService(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public void ProcessContract(Contract contract, int numInstallments)
        {
            double basicQuota = contract.TotalValue / numInstallments;

            for (int i = 1; i <= numInstallments; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _taxService.MonthTax(basicQuota, i);
                double totalQuota = updatedQuota + _taxService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, totalQuota));
            }
        }
    }
}
