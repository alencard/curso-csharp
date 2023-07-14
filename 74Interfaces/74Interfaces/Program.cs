using _74Interfaces.Entities;
using System.Globalization;
using _74Interfaces.Services;

namespace _74Interfaces
{
    class Program
    {
        static void Main()
        {
            CarRental rental;
            RentalService rentalService;
            string carName;
            DateTime start;
            DateTime finish;
            double pricePerHour;
            double pricePerDay;

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            carName = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            rental = new(start, finish, new Vehicle(carName));

            rentalService = new(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(rental);

            Console.WriteLine();
            Console.WriteLine("Invoice:");
            Console.WriteLine(rental.Invoice);
        }
    }
}