using System.Data.Entity;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL.Repositories
{
    public class ComfortRepository : Repository<Comfort>
    {
        public ComfortRepository(DbContext context) : base(context) { }
    }
}