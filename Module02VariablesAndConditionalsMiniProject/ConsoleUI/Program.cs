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
            string firstName = "";
            string ageText = "";
            bool isValidAge = false;

            /*
             * USING MY OWN CODE
             */
            //Console.WriteLine("=========== this is using my own code");
            //Console.Write("Please enter your first name: ");
            //firstName = Console.ReadLine();

            //Console.Write("Please enter your age: ");
            //ageText = Console.ReadLine();

            //isValidAge = int.TryParse(ageText, out int age);

            //if (isValidAge)
            //{
            //    if (age < 21)
            //    {
            //        Console.WriteLine($"Hi {firstName}. Please wait {21 - age} years to start this class.");
            //    }
            //    else if(firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
            //    {
            //        Console.WriteLine($"Hi Professor {firstName}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Welcome to the class, {firstName}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Age is invalid. Application aborted.");
            //}


            /*
             * USING TIM COREY
             */

            Console.WriteLine("=========== This is using Tim Corey's code");
            //Ask for the user's first name
            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();

            //Ask the user for their age (numerical value)
            Console.Write("What is your age: ");
            ageText = Console.ReadLine();

            //Convert ageText to age (string to int)
            isValidAge = int.TryParse(ageText, out int userAge);

            if(isValidAge == false)
            {
                Console.WriteLine("That was not a valid age.");
                Console.ReadLine();
                return; //closes out the method, in this case, the Main method.
            }

            string formattedName = "";

            if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
            {
                formattedName = $"Professor {firstName}";
            }
            else
            {
                formattedName = firstName;
            }

            if (userAge < 21)
            {
                Console.WriteLine($"I recommend you wait {21 - userAge} years to start this class {formattedName}");
            }
            else
            {
                Console.WriteLine($"Welcome to class {formattedName}");
            }

            Console.ReadLine();
        }
    }
}
