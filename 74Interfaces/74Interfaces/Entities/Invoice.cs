using System.Globalization;
using System.Text;

namespace _74Interfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Basic payment: R${BasicPayment.ToString("f2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Tax: R${Tax.ToString("f2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Basic payment: R${TotalPayment.ToString("f2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
