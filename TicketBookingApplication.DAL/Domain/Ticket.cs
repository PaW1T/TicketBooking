using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.DAL.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public int ComfortId { get; set; }
        public decimal Price { get; set; }

        [Index("Ticket_FlightSeat", 1, IsUnique = true)]
        public int FlightId { get; set; }

        [Index("Ticket_FlightSeat", 2, IsUnique = true)]
        public int SeatNumber { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual Comfort Comfort { get; set; }
    }
}
