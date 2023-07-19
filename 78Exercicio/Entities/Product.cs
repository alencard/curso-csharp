using System.Globalization;

namespace _78Exercicio.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (obj is not Product)
            {
                throw new ArgumentException("The type is wrong");
            }

            Product other = obj as Product;

            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name}, R${Price.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
