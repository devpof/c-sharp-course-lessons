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
             * Methods
             * 
             * Naming Convention: Pascal Case. Each word, the first letters are capitalized.
             * Best Practice:
             *  Use D.R.Y. principle: DON'T REPEAT YOURSELF
             *  A method should only do one thing. Then name it by what it does.
             *      
             */
            SayAuthor();

            string firstName = GetUsersName("What is your first name: ");
            string lastName = GetUsersName("What is your last name: ");

            WelcomeUser(firstName, lastName);

            //Don't need it anymore in Visual Studio 2019. Earlier versions you will need it.
            //Since the debugger in VS2019 already waits for the key
            //Console.ReadLine();
        }

        private static void SayAuthor()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Written by: Yours Truly");
            Console.WriteLine("for the Foundation in C# course");
            Console.WriteLine("****************************");
        }

        private static void WelcomeUser(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}");
        }

        private static string GetUsersName(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    }
}
