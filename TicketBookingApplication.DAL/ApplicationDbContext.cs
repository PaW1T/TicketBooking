using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=AirportDb") { }

        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Comfort> Comforts { get; set; }
        public virtual DbSet<Airplane> Airplanes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<OrderedTicket> OrderedTickets { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
