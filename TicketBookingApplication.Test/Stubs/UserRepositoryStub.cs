using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL.Domain;
using TicketBookingApplication.DAL.Repositories;

namespace TicketBookingApplication.Test
{
    class UserRepositoryStub : IRepository<User>
    {
        public IQueryable<User> AllEntities => new List<User> { new User {Login = "user", Password = "password" } }.AsQueryable();

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User item)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
