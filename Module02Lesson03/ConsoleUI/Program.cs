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

            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            /*
             * If, If-Else, If-Else If, If-Else If-Else Statements
             * 
             * condition that only returns a true or false
             */
            if (firstName.ToLower() == "firstname" && lastName.ToLower() == "lastname")
            {
                Console.WriteLine("Hello Mr. lastname");
            }
            else if (firstName.ToLower() == "firstname")
            {
                Console.WriteLine("Hello other firstname");
            }
            else
            {
                Console.WriteLine("Hello other person. I do not know who you are.");
            }


            /*
             * Switch Statement
             */
            switch (firstName.ToLower())
            {
                case "sensei":
                    Console.WriteLine("Hello sensei");
                    break;
                case "love":
                    Console.WriteLine("Hello love");
                    break;
                default:
                    Console.WriteLine("Who are you?");
                    break;
            }

            Console.WriteLine("Application Done");

            Console.ReadLine();

        }
    }
}
