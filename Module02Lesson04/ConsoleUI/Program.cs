using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string ageText = Console.ReadLine();

            //unsafe way to convert from string to int
            //int age = int.Parse(ageText);

            //safe way - one of the many ways to do it
            //out variable
            bool isValidAge = int.TryParse(ageText, out int age);

            if (isValidAge)
            {
                int ageIn2000 = age -= 20;
                if (ageIn2000 >= 0)
                {
                    Console.WriteLine($"You were {ageIn2000} years old back in 2000");
                }
                else
                {
                    Console.WriteLine("You were not born yet back in 2000");
                }
            }
            else
            {
                Console.WriteLine("That was not a valid age");
            }

            Console.ReadLine();

        }
    }
}
