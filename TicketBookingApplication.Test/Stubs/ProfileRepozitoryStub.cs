using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.Test
{
    class ProfileRepositoryStub : IRepository<Profile>
    {
        public IQueryable<Profile> AllEntities => throw new NotImplementedException();

        public void Add(Profile item)
        {
            
        }

        public Profile GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Profile item)
        {
            throw new NotImplementedException();
        }

        public void Update(Profile item)
        {
            throw new NotImplementedException();
        }
    }
}
