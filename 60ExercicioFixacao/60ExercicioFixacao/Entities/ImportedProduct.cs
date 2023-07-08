using System.Globalization;

namespace _60ExercicioFixacao.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; protected set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            Price += Price * CustomFee;
            return Price;
        }

        public override string PriceTag()
        {
            return $"{base.PriceTag()} (Customs fee: R${CustomFee.ToString("f2", CultureInfo.InvariantCulture)})";
        }
    }
}
