using System.Data.Entity;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL.Repositories
{
    public class AirplaneRepository : Repository<Airplane>
    {
        public AirplaneRepository(DbContext context) : base(context) { }
    }
}
