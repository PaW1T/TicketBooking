using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketBookingApplication.Startup))]
namespace TicketBookingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
