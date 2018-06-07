using System.Data.Entity;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL.Repositories
{
    public class CityRepository : Repository<City>
    {
        public CityRepository(DbContext context) : base(context) { }
    }
}