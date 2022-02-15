using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        //AUTO PROPERTY
        //this is how you setup common class that stores data.
        //you can make the get/set private if you don't want
        //a property to be set or to get
        //in general stick with this until you need to do custom
        public string FirstName { get; set; }
        public string LastName { get; private set; }
        //public int Age { get; set; }

        //FULL PROPERTY
        //This is equivalent to the public int Age { get; set; }
        //but you get more control for setting the data. This is how
        //handle doing some validations or custom calculations on the data.
        //modifying the set for data validation is more on the database side.
        //So it is uncommon to do a custom set function. OTOH, the
        //get property is common. Example for custom get are CC Number, password, etc.
        //for set property that are private, you can build a method which will set the value
        //for that property.

        //private backing field. Standard way of creating this type of field is 
        //start off with an underscore and then camelCase
        private int _age; 

        public int Age
        {
            get { return _age; }
            set 
            {
                //value is a special keyword that contains the value
                //when set is called.
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range.");
                }
            }
        }

        //public string SSN { get; set; }
        private string _ssn;

        public string SSN
        {
            get
            {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set { _ssn = value; }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        //taking out get/set in a full property.
        //This is just an example, you must have encryption to store passwords
        private string _password;

        //delete get so that no one can get the password.
        public string Password
        {            
            set { _password = value; }
        }

        //CONSTRUCTOR
        //is a special type of method that gets run when you build your class
        //if you don't have this, there is one behind the scenes that is auto-generated.
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }

        public PersonModel()
        {

        }
    }
}
