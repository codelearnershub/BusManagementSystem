using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Entities
{
    public class Passenger : User
    {
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
