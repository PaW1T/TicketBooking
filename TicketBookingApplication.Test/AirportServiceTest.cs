using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketBookingApplication.DAL;
using TicketBookingApplication.BL.Services;
using TicketBookingApplication.DAL.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TicketBookingApplication.Test
{
    [TestClass]
    public class AirportServiceTest
    {
        private UnitOfWorkStub stub = new UnitOfWorkStub
        {
            AirplaneRepository = new AirplaneRepositoryStub(),
            CityRepository = new CityRepositoryStub(),
            FlightRepository = new FlightRepositoryStub(),
            ProfileRepository = new ProfileRepositoryStub(),
            TicketRepository = new TicketRepositoryStub(),
            UserRepository = new UserRepositoryStub()
        };

        [TestMethod]
        public void Cities_Property_Get()
        {
            var service = new AirportService(stub);

            var cities = service.Cities;

            Assert.IsNotNull(cities);
        }

        [TestMethod]
        public void FindFlights_NoExsistingFlights_ReturnsEmptyCollection()
        {
            var service = new AirportService(stub);

            var flights = service.FindFlights(-1, -1, DateTime.Now);
            var flightsCount = flights.Count;

            Assert.AreEqual(0, flightsCount);
        }

        [TestMethod]
        public void FindFlights_OneFlightAvailable_ReturnsCollectionWithOneItem()
        {
            var service = new AirportService(stub);


            var flights = service.FindFlights(1, 2, DateTime.Now);
            var flightsCount = flights.Count;

            Assert.AreEqual(1, flightsCount);
        }

        [TestMethod]
        public void LoginUser_WrongPasswordAndLogin_ReturnsNull()
        {
            var service = new AirportService(stub);

            var user = service.LoginUser("login", "password");

            Assert.IsNull(user);
        }

        [TestMethod]
        public void LoginUser_ExsistingLoginAndPassword_ReturnsUserInstance()
        {
            var service = new AirportService(stub);

            var user = service.LoginUser("user", "password");

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void CreateProfile_PassValidArguments_ProfileCreated()
        {
            var name = "name";
            var surname = "surname";
            var age = 30;
            var sex = false;

            var service = new AirportService(stub);

            var profile = service.CreateProfile(name, surname, age, sex);
            var allPropertiesAreSame = profile.Age == age && profile.Name == name && profile.Surname == surname && profile.Sex == sex;

            Assert.IsTrue(allPropertiesAreSame);
        }
    }
}
