using System.Web.Mvc;
using TicketBookingApplication.BL.Services;
using TicketBookingApplication.Models;

namespace TicketBookingApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly AirportService _airportService = new AirportService();

        public ActionResult Index()
        {
            var cities = _airportService.Cities;
            return View(cities);
        }

        public ActionResult Search(SearchViewModel model)
        {
            var errorString = string.Empty;
            if(model.DepartureCityId == -1)
            {
                errorString += "Выберите город отправки ";
            }
            if(model.ArrivalCityId == -1)
            {
                errorString += "Выберите город прибытия";
            }
            if(model.DepartureDate == null)
            {
                errorString += "Выберите дату";
            }
            
            if(errorString!= string.Empty)
            {
                ViewBag.Error = errorString;
                return View();
            }
            else
            {
                var fligths =_airportService.FindFlights(model.DepartureCityId, model.ArrivalCityId, model.DepartureDate.Value);
                return View(fligths);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}