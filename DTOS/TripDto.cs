using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.DTOS
{
    public class TripDto
    {
        public int Id { get; set; }

        public string TripReference { get; set; }

        public int BusId { get; set; }

        public string BusModel { get; set; }

        public string BusRegistrationNumber { get; set; }

        public Location TakeOffPoint { get; set; }

        public Location LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public int DriverId { get; set; }

        public string DriverFullName { get; set; }

        public decimal Price { get; set; }

        public TripStatus Status { get; set; }

        public virtual List<BookingDto> Bookings { get; set; } = new List<BookingDto>();
    }

    public class CreateTripRequestModel
    {
        public string BusRegistrationNumber { get; set; }

        public Location TakeOffPoint { get; set; }

        public Location LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public string DriverLicenseNumber { get; set; }

        public decimal Price { get; set; }
    }

    public class UpdateTripRequestModel
    {
        public int BusId { get; set; }

        public Location TakeOffPoint { get; set; }

        public Location LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public int DriverId { get; set; }

        public decimal Price { get; set; }
    }


}
