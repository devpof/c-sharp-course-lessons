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
             * For Loop
             * 
             * Always check your numbering with the for loop
             */
            string[] firstNames = new string[] { "John", "Hannah", "James" };

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine(firstNames[i]);
            }

            Console.WriteLine();

            List<string> lastNames = new List<string>();

            lastNames.Add("Doe");
            lastNames.Add("Smith");
            lastNames.Add("Jones");

            for (int i = 0; i < lastNames.Count; i++)
            {
                Console.WriteLine(lastNames[i]);
            }

            Console.ReadLine();
        }
    }
}
