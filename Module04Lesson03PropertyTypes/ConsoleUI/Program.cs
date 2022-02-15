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
             * PRO TIP:
             * In classes, use auto-properties by default. Move to full properties when needed.
             */
            PersonModel person = new PersonModel("Smith");
            person.FirstName = "Rose";
            //person.LastName = "Smith";
            person.Age = 30;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            AddressModel address = new AddressModel();
            address.Street = "123 Main St";
            address.City = "Honolulu";
            address.State = "HI";
            address.ZipCode = "98745";

            Console.WriteLine(address.FullAddress);

            Console.ReadLine();
        }
    }
}
