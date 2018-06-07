using System.Data.Entity;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL.Repositories
{
    public class ProfileRepository : Repository<Profile>
    {
        public ProfileRepository(DbContext context) : base(context) { }
    }
}