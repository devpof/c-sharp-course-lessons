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
             * INSTANTIATED CLASSES
             * 
             * Naming Practices of Instantiated Classes
             *  Best practice to suffix the class name with "Model"
             *  when naming a class that stores data.
             *  
             * Instantiated classes are almost exclusively used just for storing data.
             * If you need to create a method, it is recommended to do it on a separate class.
             * 
             * Static classes are for stateless processing
             */
            //Code Lines below uses public properties on class instances
            //List<PersonModel> people = new List<PersonModel>();

            //PersonModel person = new PersonModel();
            //person.firstName = "Rose";
            //people.Add(person);

            //person = new PersonModel();
            //person.firstName = "Hannah";
            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.firstName);
            //}


            //using the industry standard convention of using instance properties of a class
            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            do
            {
                Console.Write("What is your first name (or type exit to stop): ");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

            Console.ReadLine();
        }
    }
}
