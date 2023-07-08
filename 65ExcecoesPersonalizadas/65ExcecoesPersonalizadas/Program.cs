using _65ExcecoesPersonalizadas.Entities;
using _65ExcecoesPersonalizadas.Entities.Exceptions;

namespace _65ExcecoesPersonalizadas
{
    class Program
    {
        static void Main()
        {
            try
            {
                Reservation reservation;
                int room;
                DateTime checkin;
                DateTime checkout;

                Console.Write("Room number: ");
                room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation = new(room, checkin, checkout);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"General Error: {e.Message}");
            }
        }
    }
}