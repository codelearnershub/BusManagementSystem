using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Repositories
{
    interface ITripRepository
    {
        Trip Create(Trip trip);

        Trip Get(int id);

        Trip GetByReference(string reference);

        List<Trip> GetAll();

        Trip Update(Trip trip);

        void Delete(Trip trip);

        bool ExistById(int id);

    }
}
