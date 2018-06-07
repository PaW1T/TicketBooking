using System;
using System.Linq;

namespace TicketBookingApplication.DAL.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T GetById(int id);

        IQueryable<T> AllEntities { get; }
    }
}
