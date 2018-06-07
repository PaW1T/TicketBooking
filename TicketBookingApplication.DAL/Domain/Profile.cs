using System.Collections.Generic;

namespace TicketBookingApplication.DAL.Domain
{
    public class Profile
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
