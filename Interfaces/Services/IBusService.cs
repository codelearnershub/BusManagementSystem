using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Services
{
    interface IBusService
    {
        public bool Register(CreateBusRequestModel bus);

        public bool Update(Bus bus, string regNumber);

        public bool ChangeTripStatus(string regNumber, bool tripStatus);

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus);

        public bool Delete(string regNumber);

        public IList<Bus> List();

        public BusDto GetById(int id);

        public Bus GetByRegNumber(string RegNumber);

    }
}
