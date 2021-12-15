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
        static BusService busService = new BusService();
        static void Main(string[] args)
        {
            //var CreateBusRequestModel = new CreateBusRequestModel
            //{
            //    BusType = BusType.FirstClass,
            //    Capacity = 60,
            //    Model = "GoodOne",
            //    PlateNumber = "LAG46I23"
            //};
            //var result = busService.Register(CreateBusRequestModel);
            ////Console.WriteLine($"{result}");
            //var UpdateBusRequestModel = new UpdateBusRequestModel
            //{
            //    BusType = BusType.BusinessClass,
            //    PlateNumber = "OY67888",
            //};
            //var result = busService.Update("C66BD176CF", UpdateBusRequestModel);
            //Console.WriteLine($"{result}");

            var buses=busService.List();
            foreach(var bus in buses)
            {
                Console.WriteLine($"{bus.RegistrationNumber}\t{bus.Model}");
            }
            /* var bus = busService.GetById(4);
             if(bus != null)
             {
                 Console.WriteLine($"{bus.RegistrationNumber}\t{bus.Model}");
             }*/
        }
    }
}
