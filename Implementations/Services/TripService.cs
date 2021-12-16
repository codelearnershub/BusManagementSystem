using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Exceptions;
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
            var trip = _tripRepository.GetByReference(tripReferenceNumber);
            if ( trip == null) 
            {
                throw new NotFoundException($"The trip reference number {tripReferenceNumber} not found");
            }
            _tripRepository.Delete(trip);
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
            return _tripRepository.GetInitialisedTrips();
        }

        public List<TripDto> GetTripsByBus(string registrationNumber)
        {
            if (_busRepository.ExistByRegNumber(registrationNumber))
            {
                return _tripRepository.GetTripsByBus(registrationNumber);
            }
            else
            {
                throw new NotFoundException($"The Bus Registration Number{registrationNumber} entered does not exist.");
            }
        }

        public List<TripDto> GetTripsByDate(DateTime date)
        {
            return _tripRepository.GetTripsByDate(date);
        }

        public List<TripDto> GetTripsByDateAndLocation(Location from, Location to, DateTime date)
        {
            return _tripRepository.GetTripsByDateAndLocation(from, to, date);
        }

        public List<TripDto> GetTripsByDriver(int driverId)
        {
            var driver = _driverRepository.Get(driverId);
            
            if (driver == null)
            {

                throw new NotFoundException($"The driver Id {driverId} entered does not exist.");
            }
            return _tripRepository.GetTripsByDriver(driver.Id);
            
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
