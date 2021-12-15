using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem
{
    public static class Utilities
    {
        public static BusType GetBusType()
        {
            Console.WriteLine("Enter 1 for First Class");
            Console.WriteLine("Enter 2 for Business Class");
            Console.WriteLine("Enter 3 for Economy");
            int choice = int.Parse(Console.ReadLine());
            return (BusType)choice;
        }
    }
}
