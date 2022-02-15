using System;
using System.Linq;

namespace Module08Lesson13LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //LambdaTests();
            LinqTests();

            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            // Linq Statement
            //var results = (from c in contacts
            //               where c.Addresses.Count > 1
            //               select c);

            // Linq Statement joining another set of data.
            // like an INNER JOIN in SQL
            //var results = (from c in contacts
            //               join a in addresses
            //               on c.Id equals a.ContactId
            //               select new { c.FirstName, c.LastName, a.City, a.State }); // select new {} is anonymous object

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} from {item.City}, {item.State}");
            //}

            // same as above but it will only show the First and Last Name once
            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(x => x.ContactId == c.Id) });
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
            //}

            var results = (from c in contacts
                           select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => c.Addresses.Contains(a.Id)) });
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
            }
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

            var results = data.Where(x => x.Addresses.Count > 1);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            //var results = data.Select(x => x.FirstName);
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}

            //var results = data.Take(2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var results = data.Skip(2).Take(2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var results = data.OrderBy(x => x.LastName);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}
        }
    }
}
