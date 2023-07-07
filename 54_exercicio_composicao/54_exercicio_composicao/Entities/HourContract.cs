namespace _54_exercicio_composicao.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valueph, int hrs)
        {
            Date = date;
            ValuePerHour = valueph;
            Hours = hrs;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return $"Date: {Date.Month}/{Date.Year}";
        }
    }
}
