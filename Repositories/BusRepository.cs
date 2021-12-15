using BusManagementSystem.Context;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Exceptions;
using BusManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Repositories
{
    public class BusRepository : IBusRepository
    {
        private readonly ApplicationDbContext _context;

        public BusRepository()
        {
            _context = new ApplicationDbContext();
        }

        public Bus Create(Bus bus)
        {
            _context.Buses.Add(bus);
            _context.SaveChanges();
            return bus;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteBus(int id)
        {
            var bus = _context.Buses.Find(id);
            if(bus == null)
            {
                throw new NotFoundException($"Bus with id: {id} does not exist.");
            }
            else
            {
                _context.Buses.Remove(bus);
                _context.SaveChanges();
            }
        }

        public bool Exist(int id)
        {
            return _context.Buses.Any(b => b.Id == id);
        }

        public bool Exist(string regNum)
        {
            return _context.Buses.Any(b => b.RegistrationNumber == regNum);
        }

        public List<Bus> GetAll()
        {
            return _context.Buses.ToList();
        }

        public List<Bus> GetAvailableBuses()
        {
            return _context.Buses.Where(b => b.AvailabilityStatus == true).ToList();
        }

        public Bus GetBus(int id)
        {
            var bus = _context.Buses.Find(id);
            if (bus == null)
            {
                throw new NotFoundException($"Bus with id: {id} does not exist.");
            }
            return bus;
        }

        public Bus Update(int id, Bus bus)
        {
            var buss = _context.Buses.Find(id);
            if (buss == null)
            {
                throw new NotFoundException($"Bus with id: {id} does not exist.");
            }
            else
            {
                buss.Model= bus.Model;
                buss.PlateNumber = bus.PlateNumber;
                buss.RegistrationNumber = bus.RegistrationNumber;
                buss.AvailabilityStatus= bus.AvailabilityStatus;
                buss.BusType = bus.BusType;
                buss.Capacity = bus.Capacity;
                buss.TripStatus = bus.TripStatus;
            }

            _context.Buses.Update(buss);
            _context.SaveChanges();
            return buss;

        }


    }
}
