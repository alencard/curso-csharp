namespace _60ExercicioFixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; protected set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used), R${Price} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";
        }
    }
}
