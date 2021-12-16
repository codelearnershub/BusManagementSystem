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
    public class DriverRepository : IDriverRepository
    {
        private readonly ApplicationDbContext _context;

        public DriverRepository()
        {
            _context = new ApplicationDbContext();
        }

        public Driver Create(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
            return driver;
        }

        public void Delete(Driver driver)
        {
            _context.Drivers.Remove(driver);
            _context.SaveChanges();
        }

        public bool ExistById(int id)
        {
            return _context.Drivers.Any(s => s.Id == id);
        }

        public bool ExistByRegNumber(string licenseNumber)
        {
            return _context.Drivers.Any(d => d.LicenseNumber == licenseNumber);
        }

        public Driver Get(int id)
        {
            return _context.Drivers.Find(id);
        }

        public List<Driver> GetAll()
        {
            return _context.Drivers.ToList();
        }

        public Driver GetByLicenseNumber(string licenseNumber)
        {
            return _context.Drivers.SingleOrDefault(x => x.LicenseNumber == licenseNumber);
        }

        public Driver Update(Driver driver)
        {
            _context.Drivers.Update(driver);
            _context.SaveChanges();
            return driver;
        }
    }
}
