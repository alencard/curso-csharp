using _56ExercicioFixacao.Entities;
using _56ExercicioFixacao.Entities.Enums;
using System.Globalization;

namespace _56ExercicioFixacao
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("BirthDate (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new(clientName, clientEmail, birthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new(DateTime.Now, orderStatus, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qttProducts = int.Parse(Console.ReadLine());

                Product product = new(productName, price);
                OrderItem orderItem = new(qttProducts, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary");
            Console.WriteLine(order);
        }
    }
}