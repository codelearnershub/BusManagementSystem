using BusManagementSystem.Entities;
using BusManagementSystem.DTOS;
using BusManagementSystem.Enums;
using BusManagementSystem.Repositories;
using BusManagementSystem.Services;
using System;

namespace BusManagementSystem
{
    class Program
    {
        static DriverRepository driverRepository = new DriverRepository();
        static BusService busService = new BusService();
        static TripService tripService = new TripService();
        static void Main(string[] args)
        {
            //Menu.Run();
            var bus = new CreateBusRequestModel
            {
                BusType = BusType.BusinessClass,
                Capacity = 28,
                Model = "highlander",
                PlateNumber = "sd324fh"
            };
            var driver = new Driver
            {
                FirstName = "titi",
                LastName = "toto",
                Email = "toto@gmail.com",
                PhoneNumber = "09087654312",
                Address = "gbonagun abeokuta",
                LicenseNumber = "12345",
                Password = "2709"
            };
            //busService.Register(bus);
            // driverRepository.Create(driver);
            var trip = new CreateTripRequestModel
            {
                BusRegistrationNumber = "38CB256588",
                DriverLicenseNumber = "12345",
                LandingPoint = Location.Ajah,
                LandingTime = DateTime.Parse("2022-2-12 3:44:01"),
                TakeOffPoint = Location.Ibadan,
                TakeOffTime = DateTime.Parse("2022-2-12 1:00:01"),
                Price = 15000.00M
            };
            // tripService.Schedule(trip);
            //tripService.Delete("4DC14AF45");

            var trips = tripService.GetTripsByDate(DateTime.Parse("2022 - 02 - 12"));

            foreach(var tr in trips)
            {
                Console.WriteLine($"{tr.BusModel} {tr.TripReference}");
            }
        }
    }
}
