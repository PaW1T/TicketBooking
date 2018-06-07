using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.Test
{
    class FlightRepositoryStub : IRepository<Flight>
    {
        public IQueryable<Flight> AllEntities { get; } = new List<Flight> { new Flight { DepartureCityId = 1, ArrivalCityId = 2, DepartureTime = DateTime.Now } }.AsQueryable();

        public void Add(Flight item)
        {
            throw new NotImplementedException();
        }

        public Flight GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Flight item)
        {
            throw new NotImplementedException();
        }

        public void Update(Flight item)
        {
            throw new NotImplementedException();
        }
    }
}

