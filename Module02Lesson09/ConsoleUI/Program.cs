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
             * Sets: Dictionary<TKey, TValue>
             * 
             * order is not a problem here.
             * putting a different value on the same key will overwrite the old value.
             * It cannot have duplicate keys
             */
            Dictionary<int, string> importantYears = new Dictionary<int, string>();

            importantYears[1492] = "Columbus discovered the new world.";
            importantYears[1969] = "Man walks on the moon.";
            importantYears[1901] = "I was born.";

            Console.WriteLine($"In the year 1901, this happened: {importantYears[1901]}");


            Console.ReadLine();
        }
    }
}
