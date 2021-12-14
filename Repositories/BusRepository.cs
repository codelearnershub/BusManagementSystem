using BusManagementSystem.Context;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
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

        public void DeleteBus(int id)
        {
            var bus = _context.Buses.Find(id);
            if(bus == null)
            {
                throw new KeyNotFoundException($"Bus with id: {id} does not exist.");
            }
            else
            {
                _context.Buses.Remove(bus);
                _context.SaveChanges();
            }
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
                throw new KeyNotFoundException($"Bus with id: {id} does not exist.");
            }
            return bus;
        }

        public Bus Update(Bus bus)
        {
            var b = _context.Buses.Find(bus.Id);
            if (b == null)
            {
                throw new KeyNotFoundException($"Bus with id: {bus.Id} does not exist.");
            }
            _context.Update(bus);
            _context.SaveChanges();
            return bus;

        }
    }
}
