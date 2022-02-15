using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /*
     * GENERICS
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            string result = FizzBuzz("Tests");
            Console.WriteLine($"Tests: {result}");

            result = FizzBuzz(123);
            Console.WriteLine($"123: {result}");

            result = FizzBuzz("123456789012345");
            Console.WriteLine($"123456789012345: {result}");

            result = FizzBuzz(true);
            Console.WriteLine($"true: {result}");

            //This returns Buzz because it counts the length of the value Generics.PersonModel (namespace.class)
            //which has a length of 20
            PersonModel pm = new PersonModel { FirstName = "John", LastName = "Doe" };
            result = FizzBuzz(pm);
            Console.WriteLine($"{pm}: {result}");

            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "John", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected.");
            }

            Console.ReadLine();
        }

        // if a number is divisible by
        // 3 - Fizz
        // 5 - Buzz
        // 3 and 5 - FizzBuzz
        // <T> means that FizzBuzz is going to use 1 generic type
        // we give the name T inside an angle brackets.
        // T is a convention not a rule, but it would be easier for other coders to have the same name.
        private static string FizzBuzz<T>(T item)
        {
            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

            return output;
        }
    }

    public class GenericHelper<T> where T: IErrorCheck
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();


        public void CheckItemAndAdd(T item)
        {
            if (item.HasError == false)
            {
                Items.Add(item); 
            }
            else
            {
                RejectedItems.Add(item);
            }
        }
    }

    public interface IErrorCheck
    {
        bool HasError { get; set; }
    }

    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearManufactured { get; set; }
        public bool HasError { get; set; }
    }

    public class PersonModel : IErrorCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError { get; set; }
    }
}
