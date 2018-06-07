using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.DAL.Domain
{
    public class Flight
    {
        public int Id { get; set; }
        public int AirplaneId { get; set; }
        public int ArrivalCityId { get; set; }
        public int DepartureCityId { get; set; }
        public DateTime ArivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public virtual Airplane Airplane { get; set; }

        [ForeignKey("ArrivalCityId")]
        public virtual City ArrivalCity { get; set; }

        [ForeignKey("DepartureCityId")]
        public virtual City DepartureCity { get; set; }
    }
}
