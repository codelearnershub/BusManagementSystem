using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Services
{
    public class BusService : IBusService
    {
        private readonly BusRepository _busRepository;

        public BusService()
        {
            _busRepository = new BusRepository();
        }

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus)
        {
            throw new NotImplementedException();
        }

        public bool ChangeTripStatus(string regNumber, bool tripStatus)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string regNumber)
        {
            throw new NotImplementedException();
        }

        public BusDto GetById(int id)
        {
            var bus = _busRepository.Get(id);
            if(bus != null)
            {
                return new BusDto
                {
                    AvailabilityStatus = bus.AvailabilityStatus,
                    BusType = bus.BusType,
                    Capacity = bus.Capacity,
                    Model = bus.Model,
                    PlateNumber = bus.PlateNumber,
                    RegistrationNumber = bus.RegistrationNumber,
                    TripStatus = bus.TripStatus,
                };
            };
            return null;

        }

        public Bus GetByRegNumber(string RegNumber)
        {
            throw new NotImplementedException();
        }

        public IList<Bus> List()
        {
            throw new NotImplementedException();
        }

        public bool Register(CreateBusRequestModel model)
        {
            var bus = new Bus
            {
                AvailabilityStatus = true,
                Capacity = model.Capacity,
                BusType = model.BusType,
                Model = model.Model,
                PlateNumber = model.PlateNumber,
                TripStatus = false,
                RegistrationNumber = Guid.NewGuid().ToString().Substring(0, 11).Replace("-", "").ToUpper(),
            };
            _busRepository.Create(bus);
            return true;
        }

        public bool Update(Bus bus, string regNumber)
        {
            throw new NotImplementedException();
        }
    }
}
