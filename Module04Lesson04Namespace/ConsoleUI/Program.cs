using System;
using System.Collections.Generic;
using ConsoleUI.Models;
using FoundationInfo;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * NAMESPACE
             * 
             * If the classes are on the same namespace, C# automatically
             * knows that you are calling that Class, unless of course, you
             * have another project in the Solution
             * 
             * Namespaces can be anything we want them to be. By default it is the same name
             * as your project.
             * 
             * By default we don't change the name of the namespaces. Instead, we create folders.
             * In general, you will see projects mainly use folders.
             * 
             * USING statement
             * - this is the one above. Example: using System
             * - it doesn't import the code like what other language is doing
             * - all it does is it creates a shortcut or assume that it is part of the current namespace.
             * 
             * PRO TIP:
             * Use namespaces to organize your applicaiton logically.
             */
            List<PersonModel> people = new List<PersonModel>();
            PersonModel person = new PersonModel();

            //full name of the class
            //using the USING statement. using FoundationInfo;
            Calculations.Add(4, 3);

            Console.ReadLine();
        }
    }
}
