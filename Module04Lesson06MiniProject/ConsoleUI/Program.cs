using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capture the information about each guest (assumption is at least one guest and uknown maximum)
// Info to capture: First name, last name and message to the host
// Once done, loop through each guest and print their info

namespace ConsoleUI
{
    class Program
    {
        /*
         * PRO TIP:
         * Design your app with just UI content in the UI. Put everything else in a class library
         * 
         * If you look at the code below, we do have Console.Write and ReadLine in this class
         * this is because it is directly related to the UI.
         * 
         */
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                
                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
    }
}
