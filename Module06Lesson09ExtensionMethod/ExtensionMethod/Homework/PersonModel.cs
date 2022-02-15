using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Homework
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Age} year/s old.");
        }
    }
}
