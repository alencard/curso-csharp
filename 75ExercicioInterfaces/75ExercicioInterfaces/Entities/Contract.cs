namespace _75ExercicioInterfaces.Entities
{
    internal class Contract
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; private set; }

        public Contract(int id, DateTime date, double value)
        {
            Id = id;
            Date = date;
            TotalValue = value;
            Installments = new();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
