using BusManagementSystem.Context;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly ApplicationDbContext _context;

        public TripRepository()
        {
            _context = new ApplicationDbContext();
        }
        public Trip Create(Trip trip)
        {
            _context.Trips.Add(trip);
            _context.SaveChanges();
            return trip;
        }

        public void Delete(Trip trip)
        {
            _context.Trips.Remove(trip);
            _context.SaveChanges();
        }

        public bool ExistById(int id)
        {
           return _context.Trips.Any(x => x.Id == id);
        }

        public Trip Get(int id)
        {
            var trip = _context.Trips.Find(id);
            return trip;
        }

        public List<Trip> GetAll()
        {
            return _context.Trips.ToList();
        }

        public Trip GetByReference(string reference)
        {
            return _context.Trips.SingleOrDefault(x => x.TripReference == reference);
        }

        public Trip Update(Trip trip)
        {
            _context.Trips.Update(trip);
            _context.SaveChanges();
            return trip;
        }
    }
}
