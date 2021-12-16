using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Entities
{
    public class Trip
    {
        public int Id { get; set; }

        public string TripReference { get; set; }

        public int BusId { get; set; }

        public Bus Bus { get; set; }

        public Location TakeOffPoint { get; set; }

        public Location LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public decimal Price { get; set; }

        public TripStatus Status { get; set; }

        public int AvailableSeat { get; set; }

        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
