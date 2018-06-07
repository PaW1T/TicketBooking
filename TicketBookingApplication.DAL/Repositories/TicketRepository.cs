using System.Data.Entity;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL.Repositories
{
    public class TicketRepository : Repository<Ticket>
    {
        public TicketRepository(DbContext context) : base(context) { }
    }
}