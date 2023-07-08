namespace _56ExercicioFixacao.Entities
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public Product Product { get; private set; }

        public OrderItem() { 
        
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
