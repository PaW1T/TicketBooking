using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.Test
{
    class CityRepositoryStub : IRepository<City>
    {
        public IQueryable<City> AllEntities => new List<City>().AsQueryable();

        public void Add(City item)
        {
            throw new NotImplementedException();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(City item)
        {
            throw new NotImplementedException();
        }

        public void Update(City item)
        {
            throw new NotImplementedException();
        }
    }
}
