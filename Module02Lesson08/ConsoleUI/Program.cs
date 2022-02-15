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
             * List
             * 
             * There is no performance issue like an array
             * You can add and remove whenever you want without restrictions like an array
             * List<T> is the most commonly used way to store a set of data.
             */
            //initializing a new list
            List<string> firstNames = new List<string>();

            firstNames.Add("Phil");
            firstNames.Add("Sue");
            firstNames.Add("Bob");

            Console.WriteLine($"The second element is {firstNames[1]}");

            firstNames.Remove("Sue");

            Console.WriteLine($"The second element is {firstNames[1]}");

            Console.ReadLine();
        }
    }
}
