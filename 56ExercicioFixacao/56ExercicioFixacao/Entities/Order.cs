using _56ExercicioFixacao.Entities.Enums;
using System.Text;
using System.Globalization;

namespace _56ExercicioFixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public double TotalPrice { get; private set; }
        public Client Client { get; private set; }
        public List<OrderItem> Items { get; private set; } = new();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public double Total()
        {
            TotalPrice = 0;
            foreach (OrderItem item in Items)
            {
                TotalPrice += item.SubTotal();
            }

            return TotalPrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.Day}/{Client.BirthDate.Month}/{Client.BirthDate.Year}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, R${item.Product.Price.ToString("f2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: R${item.SubTotal().ToString("f2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: R${Total().ToString("f2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
