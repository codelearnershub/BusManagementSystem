using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Services
{
    public interface ITripService
    {
        bool Schedule(CreateTripRequestModel model);

        TripDto Get(int id);

        TripDto GetByReference(string reference);

        List<TripDto> GetAll();

        List<TripDto> GetTripsByDate(DateTime date);

        List<TripDto> GetTripsByDateAndLocation(Location from, Location to, DateTime date);

        List<TripDto> GetAvailableTrips(Location from, Location to, DateTime date);

        List<TripDto> GetCancelledTripsByDate(DateTime date);

        List<TripDto> GetCompletedTrips();

        List<TripDto> GetTripsByBus(string registrationNumber);

        List<TripDto> GetTripsByDriver(int driverId);

        List<TripDto> GetInitialisedTrips();

        List<TripDto> GetCancelledTrips();

        TripDto RescheduleTrip(UpdateBusRequestModel model, string tripReferenceNumber);

        void Delete(string tripReferenceNumber);

        TripDto UpdateTripStatus(string tripReferenceNumber, TripStatus tripStatus);
   
    }

}
