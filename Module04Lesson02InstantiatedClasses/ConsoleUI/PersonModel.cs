using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //think of this class as a blueprint
    public class PersonModel
    {
        //public string firstName;
        //public string lastName;
        //public string emailAddress;

        //auto property - simplest and most common property
        //prop snippet keyword
        //naming standard is different. It uses Pascal Case.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }
    }
}
