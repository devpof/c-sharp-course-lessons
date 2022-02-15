using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Build a console guest book.Ask for their name and how many are in their party.
//Keep track of how many people are at the party.At the end, print out the guest list and the total number of guests

//Ask for the user's name
//Add the name to the list of names
//Ask for the user's party count
//Add the party count to the total party number
//Print out all names
//Print out total party number

namespace ConsoleUI
{
    class LessonCode
    {
        private static List<string> parties = new List<string>();
        private static int totalGuests = 0;

        public static void LessonMain()
        {
            LoadGuests();

            DisplayGuests();

            DisplayGuestCount();
        }

        private static void DisplayGuestCount()
        {
            Console.WriteLine();

            Console.WriteLine($"Total Guests: {totalGuests}");
        }

        private static void DisplayGuests()
        {
            Console.WriteLine();
            Console.WriteLine("Guest Parties at Event:");

            foreach (string name in parties)
            {
                Console.WriteLine(name);
            }
        }

        private static void LoadGuests()
        {
            string moreGuestsComing = "";

            do
            {
                string partyName = GetInfoFromConsole("What is your party/group name: ");

                parties.Add(partyName);

                totalGuests += GetPartySize();

                moreGuestsComing = GetInfoFromConsole("Do you want to add another guests (yes/no): ");
            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }

        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;

            do
            {
                string partySizeText = GetInfoFromConsole("How many people are in your party: ");

                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }
    }
}
