using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketBookingApplication.Models
{
    public class SearchViewModel
    {
        public int DepartureCityId { get; set; }
        public int ArrivalCityId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string OrderField { get; set; }
        public string OrderDirection { get; set; }
    }
}