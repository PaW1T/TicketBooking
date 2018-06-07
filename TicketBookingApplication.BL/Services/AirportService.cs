using System;
using System.Collections.Generic;
using System.Linq;
using TicketBookingApplication.DAL;
using TicketBookingApplication.DAL.Domain;

namespace TicketBookingApplication.BL.Services
{
    public class AirportService
    {
        private readonly IUnitOfWork _uow;

        public AirportService()
        {
            _uow = new UnitOfWork();
        }

        public AirportService(IUnitOfWork unit)
        {
            _uow = unit;
        }

        public List<City> Cities
        {
            get => _uow.CityRepository.AllEntities.ToList();
        }

        public ICollection<Flight> FindFlights(int departureCityId, int arrivalCityId, DateTime departureDate)
        {
            var thisDay = departureDate.Date;
            var nextDay = thisDay.AddDays(1);
            var flights = from flight in _uow.FlightRepository.AllEntities
                          where flight.DepartureCityId == departureCityId &&
                                flight.ArrivalCityId == arrivalCityId &&
                                flight.DepartureTime >= thisDay &&
                                flight.DepartureTime < nextDay
                          select new
                          {
                              Id = flight.Id,
                              Airplane = flight.Airplane,
                              ArivalTime = flight.ArivalTime,
                              DepartureCity = flight.DepartureCity,
                              ArrivalCity = flight.ArrivalCity,
                              DepartureTime = flight.DepartureTime
                          };

            return flights.ToList().Select(x => new Flight
            {
                Id = x.Id,
                Airplane = x.Airplane,
                ArivalTime = x.ArivalTime,
                DepartureCity = x.DepartureCity,
                ArrivalCity = x.ArrivalCity,
                DepartureTime = x.DepartureTime
            }).ToList();
        }

        public User LoginUser(string login, string password)
        {
            return _uow.UserRepository.AllEntities.SingleOrDefault(x => x.Login == login && x.Password == password);
        }

        public Profile CreateProfile(string name, string surname, int age, bool sex)
        {
            var profile = new Profile
            {
                Age = age,
                Name = name,
                Sex = sex,
                Surname = surname
            };
            _uow.ProfileRepository.Add(profile);
            _uow.Save();

            return profile;
        }

        public User CreateUser(Profile profile, string login, string password, string email)
        {
            var user = _uow.UserRepository.AllEntities.SingleOrDefault(x => x.Login == login);

            if (user == null)
            {
                user = new User
                {
                    Login = login,
                    Email = email,
                    RegistrationDate = DateTime.Now,
                    Password = password,
                    Profile = profile
                };

                 _uow.UserRepository.Add(user);
                _uow.Save();
            }

            return user;
        }
    }
}
