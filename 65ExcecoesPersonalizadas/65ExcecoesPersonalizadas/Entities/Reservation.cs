using System.Diagnostics.Metrics;
using _65ExcecoesPersonalizadas.Entities.Exceptions;

namespace _65ExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime Checkin { get; private set; }
        public DateTime Checkout { get; private set; }

        public Reservation()
        {

        }

        public Reservation(int room, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = room;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {Checkin:dd/MM/yyyy}, check-out: {Checkout:dd/MM/yyyy}, {Duration()} nights";
        }
    }
}
