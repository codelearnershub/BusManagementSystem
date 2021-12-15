using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusManagementSystem.DTOS;
using BusManagementSystem.Enums;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Services;

namespace BusManagementSystem
{
    public static class Menu
    {
        private static BusService _busService = new BusService();

        public static void Run()
        {
            bool flag = true;
            Console.WriteLine("Welcome to BMS");
            do
            {
                PrintMainMenu();
                Console.WriteLine("Enter your option");
                int option = HandleOption(Console.ReadLine());
                flag = HandleMainMenu(option);
            }
            while (flag);
            Console.WriteLine("Thank you for using our app");
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("Enter 1 for Bus Management");
            Console.WriteLine("Enter 0 to end");
        }

        public static bool HandleMainMenu(int option)
        {
            switch (option)
            {
                case 1:
                    PrintBusSubMenuOptions();
                    HandleBusSubMenuOption(HandleOption(Console.ReadLine()));
                    return true;
                case 0:
                    return false;
                default:
                    return false;
            }
        }

        public static void PrintBusSubMenuOptions()
        {
            Console.WriteLine("Enter 1 to Register Bus");
            Console.WriteLine("Enter 2 to Update Bus");
            Console.WriteLine("Enter 3 to Delete Bus");
            Console.WriteLine("Enter 4 to Find Bus");
            Console.WriteLine("Enter 5 to List Buses");
            Console.WriteLine("Enter 6 to Check Available buses");
            Console.WriteLine("Enter 0 to go back");
        }

        public static bool HandleBusSubMenuOption(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter bus model: ");
                    string model = Console.ReadLine();
                    Console.WriteLine("Enter bus capacity: ");
                    int capacity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bus Plate Number: ");
                    string plateNumber = Console.ReadLine();
                    Console.WriteLine("Enter choose bus type: ");
                    BusType busType = Utilities.GetBusType();
                    var createBusRequestModel = new CreateBusRequestModel
                    {
                        BusType = busType,
                        Capacity = capacity,
                        Model = model,
                        PlateNumber = plateNumber
                    };
                    _busService.Register(createBusRequestModel);
                    PrintBusSubMenuOptions();
                    HandleBusSubMenuOption(HandleOption(Console.ReadLine()));
                    return true;
                case 0:
                    return false;
                default:
                    return false;
            }
        }

        public static int HandleOption(string option)
        {
            bool check = false;
            int val = 0;
            while (!check)
            {
                bool result = int.TryParse(option, out val);
                if (result)
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                    option = Console.ReadLine();
                }
            }
            return val;
        }
    }
}
