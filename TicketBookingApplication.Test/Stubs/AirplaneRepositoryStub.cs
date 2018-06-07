using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.Test
{
    class AirplaneRepositoryStub : IRepository<Airplane>
    {
        public IQueryable<Airplane> AllEntities => throw new NotImplementedException();

        public void Add(Airplane item)
        {
            throw new NotImplementedException();
        }

        public Airplane GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Airplane item)
        {
            throw new NotImplementedException();
        }

        public void Update(Airplane item)
        {
            throw new NotImplementedException();
        }
    }
}
