using System.Globalization;

namespace _75ExercicioInterfaces.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{DueDate:dd/MM/yyyy} - {Amount.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
