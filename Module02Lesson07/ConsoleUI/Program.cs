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
             * Array 
             * 
             * it is 0 based in the indexes
             * Arrays hold existing data well but there are better options.
             */
            //THIS IS MANUAL WAY
            //string[] firstNames = new string[5];

            //firstNames[0] = "John";
            //firstNames[1] = "Hannah";
            //firstNames[2] = "Jane";
            //firstNames[4] = "Rose";

            //Console.WriteLine($"My array has {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

            //THIS IS USING SPLIT METHOD OF STRING DATA TYPE
            string data = "John,Hannah,Jane,Rose";
            string[] firstNames = data.Split(',');
            Console.WriteLine($"The third first name is {firstNames[2]}");

            //USING INT ARRAY
            //int[] ages = new int[3];
            //ages[0] = 4;
            //ages[1] = 5;
            //ages[2] = 30;

            //ANOTHER WAY TO DECLARE AN ARRAY
            string[] lastnames = new string[] { "Doe", "Smith", "Jones" };

            Console.ReadLine();
        }
    }
}
