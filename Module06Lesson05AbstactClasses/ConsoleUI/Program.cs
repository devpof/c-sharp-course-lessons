using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
     * Abstract Class
     * A class that is a base class. You built on it but it is not fully formed.
     * They cannot be instantiated
     */
    class Program
    {
        static void Main(string[] args)
        {
            List
            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;

    }
}
