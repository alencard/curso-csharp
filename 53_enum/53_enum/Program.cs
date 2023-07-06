using _53_enum.Entities;
using _53_enum.Entities.Enums;

namespace _53_enum
{
    class Program
    {
        static void Main()
        {
            Order order = new()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivere");

            Console.WriteLine(os);
        }
    }
}