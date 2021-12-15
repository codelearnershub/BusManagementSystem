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

        Bus Get(int id);

        List<Bus> GetAll();

        List<Bus> GetAvailableBuses();

        Bus Update(int id, Bus bus);

        void Delete(string regNumber);

        bool ExistById(int id);

        bool ExistByRegNumber(string regNum);
    }
}
