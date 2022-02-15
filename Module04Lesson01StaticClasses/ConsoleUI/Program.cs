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
             * STATIC CLASSES
             * 
             * Static means you get one copy for your entire application
             * If without Access Modifiers when declaring the class, it defaults to 'internal'
             * 
             * if a class is static, it will not let you create non-static methods.
             * 
             * You don't typically store data in a static class. So do not store data by default
             * 
             * PRO TIP:
             *  Use class files to separate your code so that each class and each method has its own purpose.
             */
            string firstName = RequestData.GetAString("What is your first name: ");

            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");

            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultsMessage($"The sum of {x} and {y} is {result}");

            Console.ReadLine();
        }

    }
}
