using System.Globalization;
using _75ExercicioInterfaces.Entities;
using _75ExercicioInterfaces.Services;

namespace _75ExercicioInterfaces
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the number of installments: ");
            int numInstallments = int.Parse(Console.ReadLine());

            Contract contract = new(id, date, value);

            ContractService contractService = new(new PaypalTax());
            contractService.ProcessContract(contract, numInstallments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}