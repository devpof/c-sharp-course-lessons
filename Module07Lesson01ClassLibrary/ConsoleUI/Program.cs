// Testing different library types
//using NETFrameworkLibrary;
//using NETCoreLibrary;
using NETStandardLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Since generators is a .NET Framework, this Program.cs
            // will also not going to be cross-platform even if
            // this is a .NET Core application.
            // Be careful of the lowest common denominator.
            // Once you used something that is only for Windows,
            // your entire application can only work on Windows.
            Generators generators = new Generators();
            PersonModel person = new PersonModel
            {
                Prefix = "Mr.",
                FirstName = "James",
                LastName = "Bond"
            };


            string message = generators.WelcomeMessage(person.Prefix, person.LastName);
            Console.WriteLine(message);
            message = generators.FarewellMessage(person.Prefix, person.LastName);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
