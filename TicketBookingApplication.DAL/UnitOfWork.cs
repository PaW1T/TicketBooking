using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.DAL
{
    public class UnitOfWork:IUnitOfWork
    {
        private static ApplicationDbContext _context = new ApplicationDbContext();

        public IRepository<Airplane> AirplaneRepository { get; } = new AirplaneRepository(_context);
        public IRepository<City> CityRepository { get; } = new CityRepository(_context);
        public IRepository<Comfort> ComfortRepository { get; } = new ComfortRepository(_context);
        public IRepository<Flight> FlightRepository { get; } = new FlightRepository(_context);
        public IRepository<Order> OrderRepository { get; } = new OrderRepository(_context);
        public IRepository<Profile> ProfileRepository { get; } = new ProfileRepository(_context);
        public IRepository<Ticket> TicketRepository { get; } = new TicketRepository(_context);
        public IRepository<User> UserRepository { get; } = new UserRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
