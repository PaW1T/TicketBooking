using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.DAL.Domain
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PostIndex { get; set; }

        [InverseProperty("ArrivalCity")]
        public virtual ICollection<Flight> FlightsAsArrival { get; set; }

        [InverseProperty("DepartureCity")]
        public virtual ICollection<Flight> FligtsAsDeparture { get; set; }
    }
}
