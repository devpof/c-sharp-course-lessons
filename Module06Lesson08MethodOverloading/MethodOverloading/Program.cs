using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    /*
     * Method Overload
     * Having multiple methods with same name but the signature line
     * is different with each other.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("John","Smith");

            person.GenerateEmail("johnsmith.com", false);

            Console.WriteLine(person.Email);

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("aol.com", true);
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)}{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}.{LastName}@{domain}";
            }
        }
    }
}
