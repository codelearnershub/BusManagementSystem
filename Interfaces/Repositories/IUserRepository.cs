using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Repositories
{
    public interface IUserRepository
    {
        bool Create(User user);

        UserDto Get(int id);

        List<UserDto> GetAll();

        UserDto GetByUsername(string username);

        List<UserDto> GetAllDrivers();

        List<UserDto> GetAllPassengers();

        UserDto Update(User user);

        void Delete(User user);

        bool ExistById(int id);

        bool ExistByUsername(string username);
    }
}
