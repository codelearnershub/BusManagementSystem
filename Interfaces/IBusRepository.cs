using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces
{
    interface IBusRepository
    {
        Bus Create(Bus bus);

        Bus GetBus(int id);

        List<Bus> GetAll();

        List<Bus> GetAvailableBuses();

        Bus Update(Bus bus);

        void DeleteBus(int id);
    }
}
