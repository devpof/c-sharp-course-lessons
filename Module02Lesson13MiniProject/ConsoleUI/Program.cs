using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static Dictionary<string, int> guestList = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            //Build a console guest book.Ask for their name and how many are in their party.
            //Keep track of how many people are at the party.At the end, print out the guest list and the total number of guests

            LoadApp();

            //Print out guest list
            PrintGuestList();

            //Print out total number of guest
            PrintTotalNumberOfGuests();


            //To run the source code that the Lesson uses. Comment out the codes above first!
            //LessonCode.LessonMain();
        }

        private static void LoadApp()
        {
            string addMoreGuestList = "y";

            do
            {
                //Ask for name and Ask for how many are in their party
                AddGuest();

                addMoreGuestList = GetInformation("Add more guest list (y/n): ");

            } while (addMoreGuestList.ToLower() == "y");
        }

        private static Dictionary<string, int> AddGuest()
        {
            string firstName = GetInformation("What is your first name: ");
            int guestNumber = GetGuestNumber();

            guestList[firstName] = guestNumber;

            return guestList;
        }

        private static string GetInformation(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }

        private static int GetGuestNumber()
        {
            int output = 0;

            do
            {
                string guestNumberText = GetInformation("How many are you: ");

                bool isValidNumber = int.TryParse(guestNumberText, out output);

                if(output == 0 || isValidNumber == false)
                {
                    Console.WriteLine("Invalid Number. Please try again");
                }

            } while (output <= 0);

            return output;
        }

        private static void PrintGuestList()
        {
            if(guestList.Count > 0)
            {
                Console.WriteLine("*************** Guest List ***************");
                foreach (var item in guestList)
                {
                    Console.WriteLine($"{item.Key} party of {item.Value}");
                }
                Console.WriteLine("******************************************");
            }
            else
            {
                Console.WriteLine("No guests as of this moment.");
            }
        }

        private static void PrintTotalNumberOfGuests()
        {
            int totalCount = 0;

            foreach (var item in guestList)
            {
                totalCount += item.Value;
            }

            Console.WriteLine($"There are a total of {totalCount} guests");
        }
    }
}
