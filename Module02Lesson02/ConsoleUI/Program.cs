using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * IMPORTANT NOTES:
 * > Always initialize your variables even if you know the default value to avoid confusion
 * > variable names are in camelCase
 * > Naming scheme should be clear to what the variable is holding
 * 
 * PRO TIP:
 * > Plan out the type of data you need before creating a variable
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * String variable data type
             * 
             * NOTE:
             * DO NOT USE the normal way of concatenating strings for large number of
             * loops or strings to concatenate. They are memory inefficient.
             * 
             * String.Empty
             * > different from null and ""
             * > this is the default value of string when it is not initialized.
             */
            string firstName = "";
            string lastName = "";
            string fullName = "";

            // slash key escapes a character in string \
            // to escape a slash you duplicate it eg: \\
            // \t represents a tab
            firstName = "\"testING 12354@*(#)@";
            Console.WriteLine(firstName);

            // String literals
            // prepend @ to tell that the string are literal characters.
            // useful on filepaths so you do not have to escape the slashes.
            string fileName = @"C:\Temp\Test.txt";
            Console.WriteLine(fileName);

            // String Interpolation
            // prepend $ and to use variables inside the string enclose
            // the variables using {varName Here}
            firstName = "FirstName";
            lastName = "LastName";
            fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);

            /*
             * Integer variable data type
             * 
             * > a whole number
             * > initial value is 0
             * > If you encounter an unsigned integer data type this means it cannot be negative.
             * 
             */
            int age = 0;
            age = 10;
            age = 25;

            /*
             * Double variable data type
             * 
             * > a number that includes a decimal point/fraction of a number
             * > double is precise only to a certain decimal point
             * > use this to store any number not related to money.
             */
            double averageWordsPerMinute = 34.24;
            Console.WriteLine(averageWordsPerMinute);

            /*
             * Decimal variable data type
             * 
             * > another data type that holds a number with decimal/fraction
             * > put a capital M after the number to indicate that it is a decimal type.
             * > by default the decimal number is in double data type
             * > is much more precise, but it takes more space in memory and more processing power
             *   to calculate decimal.
             * > If you are dealing with money, always use this type.
             */
            decimal costPerContainer = 43.85M;
            Console.WriteLine(costPerContainer);

            /*
             * Boolean variable data type
             * 
             * > only stores true or false value
             */
            bool isAlive = false;


            Console.ReadLine();
        }
    }
}
