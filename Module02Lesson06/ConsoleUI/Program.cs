using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Do Loop
             * 
             * Happens 1 or more times
             */
            string continueResult = "";
            do
            {
                Console.Write("What is your first name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine($"Hello {firstName}");

                Console.Write("Do you want to continue (yes/no): ");
                continueResult = Console.ReadLine();
            } while (continueResult.ToLower() == "yes");

            /*
             * While Loop
             * 
             * May happen 0 or more times
             */
            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            while (isValidAge == false)
            {
                Console.WriteLine("That was an invalid age. Please try again.");

                Console.Write("What is your age: ");
                ageText = Console.ReadLine();
                
                //for out parameter, you can reuse the age by taking out the data type in the out parameter.
                isValidAge = int.TryParse(ageText, out age);
            }
            Console.WriteLine($"Your age in 10 years will be {age + 10}");

            Console.ReadLine();
        }
    }
}
