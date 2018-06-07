using System;
using System.Collections.Generic;
using System.Linq;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.DAL
{
    public interface IUnitOfWork
    {
        IRepository<Airplane> AirplaneRepository { get; }
        IRepository<City> CityRepository { get; }
        IRepository<Comfort> ComfortRepository { get; }
        IRepository<Flight> FlightRepository { get; }
        IRepository<Order> OrderRepository { get; }
        IRepository<Profile> ProfileRepository { get; }
        IRepository<Ticket> TicketRepository { get; }
        IRepository<User> UserRepository { get; }

        void Save();
    }
}
