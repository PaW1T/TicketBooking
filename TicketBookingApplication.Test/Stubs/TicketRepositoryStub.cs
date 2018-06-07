using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.Test
{
    class TicketRepositoryStub : IRepository<Ticket>
    {
        public IQueryable<Ticket> AllEntities => throw new NotImplementedException();

        public void Add(Ticket item)
        {
            throw new NotImplementedException();
        }

        public Ticket GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Ticket item)
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket item)
        {
            throw new NotImplementedException();
        }
    }
}
