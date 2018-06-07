using System;

namespace TicketBookingApplication.DAL.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProfileId { get; set; }
        public bool IsPaid { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
