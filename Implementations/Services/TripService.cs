using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Services
{
    public class TripService : ITripService
    {
        private readonly TripRepository _tripRepository;
        private readonly BusRepository _busRepository;
        private readonly DriverRepository _driverRepository;
        public TripService()
        {
            _busRepository = new BusRepository();
            _tripRepository = new TripRepository();
            _driverRepository = new DriverRepository();
        }

        public void Delete(string tripReferenceNumber)
        {
            throw new NotImplementedException();
        }

        public TripDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public TripDto GetByReference(string reference)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetCancelledTrips()
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetCancelledTripsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetCompletedTrips()
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetInitialisedTrips()
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripsByBus(string registrationNumber)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripsByDateAndLocation(Location from, Location to, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripsByDriver(int driverId)
        {
            throw new NotImplementedException();
        }

        public bool Schedule(CreateTripRequestModel model)
        {
            var bus = _busRepository.GetByRegistrationNumber(model.BusRegistrationNumber);
            var driver = _driverRepository.GetByLicenseNumber(model.DriverLicenseNumber);
            var trip = new Trip
            {
                BusId = bus.Id,
                DriverId = driver.Id,
                LandingPoint = model.LandingPoint,
                LandingTime = model.LandingTime,
                TakeOffPoint = model.TakeOffPoint,
                TakeOffTime = model.TakeOffTime,
                TripReference = Guid.NewGuid().ToString().Substring(0, 10).Replace("-", "").ToUpper(),
                Price = model.Price,
                Status = TripStatus.Initialize
                
            };
             _tripRepository.Create(trip);
            return true;
            
        }

        public TripDto RescheduleTrip(UpdateBusRequestModel model, string tripReferenceNumber)
        {
            throw new NotImplementedException();
        }

        public TripDto UpdateTripStatus(string tripReferenceNumber, TripStatus tripStatus)
        {
            throw new NotImplementedException();
        }
    }
}
