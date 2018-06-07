using System.Data.Entity;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL.Repositories
{
    public class OrderedTicketRepository : Repository<OrderedTicket>
    {
        public OrderedTicketRepository(DbContext context) : base(context) { }
    }
}