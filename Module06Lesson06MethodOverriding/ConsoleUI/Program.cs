using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
     * Method Override
     * Syntax: public override <name of method>
     *
     * In order to be able to override a method you have to explicitly
     * tell that the method can be overriden.
     * To do that, you need the keywork virtual.
     * 
     * Syntax: public virtual string SayHello
     */
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Philip",
                LastName = "Fiesta",
                Email = "asdasdas@gmail.com"
            };

            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}
