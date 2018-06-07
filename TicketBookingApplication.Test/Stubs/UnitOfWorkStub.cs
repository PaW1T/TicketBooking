using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.Test
{
    class UnitOfWorkStub : IUnitOfWork
    {
        public IRepository<Airplane> AirplaneRepository { get; set; }

        public IRepository<City> CityRepository { get; set; }

        public IRepository<Comfort> ComfortRepository { get; set; }

        public IRepository<Flight> FlightRepository { get; set; }

        public IRepository<Order> OrderRepository { get; set; }

        public IRepository<Profile> ProfileRepository { get; set; }

        public IRepository<Ticket> TicketRepository { get; set; }

        public IRepository<User> UserRepository { get; set; }

        public void Save()
        {
        }
    }
}
