using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Homework
{
    public static class PersonModelExtensionMethod
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 0;
            return person;
        }

        //public static void PrintInfo(this PersonModel person)
        //{
        //    Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} year/s old.");
        //}
    }
}
