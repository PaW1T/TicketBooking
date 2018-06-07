using System.Collections.Generic;

namespace TicketBookingApplication.DAL.Domain
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
