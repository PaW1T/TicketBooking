using System.Data.Entity;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL.Repositories
{
    public class FlightRepository : Repository<Flight>
    {
        public FlightRepository(DbContext context) : base(context) { }
    }
}