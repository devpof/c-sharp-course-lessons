using ExtensionMethod.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    /*
     * Extension Method
     * 
     * Must be static
     * Static Method
     * Static Class
     * Note the keyword "this" in the parameter of the method
     * it indicates it is an extension method
     * 
     * The way it can be chained is called fluent design
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            "Hello World".PrintToConsole();

            HotelRoomModel room = new HotelRoomModel();
            room.TurnOnAir().SetTemperature(72).OpenShades();
            room.TurnOffAir().CloseShades();
            Console.WriteLine();

            /*
             * HOMEWORK
             * Create the following chain using extension methods:
             * person.SetDefaultAge().PrintInfo();
             */
            PersonModel person = new PersonModel("Hannah", "Sanger");
            person.SetDefaultAge().PrintInfo();

            Console.ReadLine();
        }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }

    public static class ExtensionSamples
    {
        // extending the string data type
        // it means you're attaching this method to any string
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }

        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}
