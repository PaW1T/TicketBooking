using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.DAL.Domain
{
    public class OrderedTicket
    {
        public int Id { get; set; }

        [Index(IsUnique = true)]
        public int TicketId { get; set; }

        [Index(IsUnique = true)]
        public int OrderId { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual Order Order { get; set; }
    }
}
