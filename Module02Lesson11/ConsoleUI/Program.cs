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
             * Loops: Foreach
             * 
             * Use foreach whenever possible for performing loops over lists
             */
            List<string> firstNames = new List<string>();

            firstNames.Add("John");
            firstNames.Add("Sue");
            firstNames.Add("Bob");
            firstNames.Add("Hannah");

            foreach (string name in firstNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Dictionary<int, string> importantYears = new Dictionary<int, string>();

            importantYears.Add(1492, "Columbus arrives in Central America");
            importantYears.Add(1969, "Man walks on the moon");
            importantYears.Add(1901, "I am born");

            foreach (var year in importantYears)
            {
                Console.WriteLine($"{year.Key} : {year.Value}");
            }

            Console.ReadLine();
        }
    }
}
