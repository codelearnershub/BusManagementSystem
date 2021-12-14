using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Repositories;
using System;

namespace BusManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRepository busRepository = new BusRepository();

            var bus = new Bus
            {
                Model = "Toyota7",
                RegistrationNumber = "AD675LND",
                PlateNumber = "AD675LND",
                Capacity = 18,
                AvailabilityStatus = true,
                BusType = BusType.FirstClass,
                TripStatus = true
            };

            var newbus = busRepository.Create(bus);
            Console.WriteLine($"BusId: {newbus.Id}, BusModel: {newbus.Model}");
        }
    }
}
