using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Enums
{
    public enum BookingStatus
    {
        Active = 1,
        Inactive,
        Council,
        Rescheduled,
        Missed,
        Onboard
    }
}
