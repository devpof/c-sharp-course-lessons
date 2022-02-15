using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    /*
     * MINI-PROJECT
     * 
     * List of Objects and save it to a CSV file
     * Adding events:
     *  If user gives bad information
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{ FirstName = "John", LastName = "Darnit", Email = "john@darnit.com" },
                new PersonModel{ FirstName = "Hannah", LastName = "Banana", Email = "hannah@yahoo.com" },
                new PersonModel{ FirstName = "Sue", LastName = "Storm", Email = "sue@aol.com" }
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel{ Manufacturer = "Toyota", Model = "Corolla"},
                new CarModel{ Manufacturer = "Honda", Model = "CRV"},
                new CarModel{ Manufacturer = "Mercedes", Model = "W20"},
                new CarModel{ Manufacturer = "Mercedes", Model = "heck"}
            };

            // take a string as literal strings so you do not have to escape slashes for path
            // you can also combined @$ for interpolation if needed.
            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;

            peopleData.SaveToCSV(people, @"C:\Temp\SavedFiles\people.csv");

            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += CarData_BadEntryFound;

            carData.SaveToCSV(cars, @"C:\Temp\SavedFiles\cars.csv");

            Console.ReadLine();
        }

        private static void CarData_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.Manufacturer} {e.Model}");
        }

        private static void PeopleData_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.FirstName} {e.LastName}");
        }
    }

    public class DataAccess<T> where T: new()
    {
        public event EventHandler<T> BadEntryFound;

        public void SaveToCSV(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();

            // blank instance of type T. Whatever type is passed in this method
            T entry = new T();

            // get the properties of type T for the list of columns.
            var cols = entry.GetType().GetProperties();

            string row = "";
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items)
            {
                row = "";
                bool badWordDetected = false;

                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();

                    badWordDetected = BadWordDetector(val);
                    if (badWordDetected == true)
                    {
                        //invoke the event
                        BadEntryFound?.Invoke(this, item);
                        //exit out of loop for this item and move on to the next one
                        break;
                    }

                    row += $",{val}";
                }

                if (badWordDetected == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
            }

            File.WriteAllLines(filePath, rows);
        }

        private bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();

            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }

            return output;
        }
    }
}
