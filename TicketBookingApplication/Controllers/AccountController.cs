using System;
using System.Web;
using System.Web.Mvc;
using TicketBookingApplication.BL.Services;
using TicketBookingApplication.Models;

namespace TicketBookingApplication.Controllers
{
    public class AccountController : Controller
    {
        private AirportService _airportService = new AirportService();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AccountViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var profile = _airportService.CreateProfile(model.Name, model.Surname, model.Age, false);
            var user = _airportService.CreateUser(profile, model.Login, model.Password, model.Email);

            var cookie = new HttpCookie("AirportLogin", model.Login)
            {
                Expires = DateTime.Now.AddMinutes(10)
            };

            Response.SetCookie(cookie);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            var user = _airportService.LoginUser(model.Login, model.Password);

            if(user != null)
            {
                var cookie = new HttpCookie("AirportLogin", model.Login)
                {
                    Expires = DateTime.Now.AddMinutes(10)
                };

                Response.SetCookie(cookie);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("loginFailed", "Не удалось войти в систему");

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            var cookie = Response.Cookies["AirportLogin"];
            if(cookie != null)
            {
                cookie.Value = string.Empty;
            }

            return RedirectToAction("Index", "Home");
        }
    }
}