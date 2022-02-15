using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Module08Lesson06SqliteUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // test to see if we can get the connection string.
            //console.writeline(getconnectionstring());

            SqliteCrud sql = new SqliteCrud(GetConnectionString());

            //CreateNewContact(sql);

            //ReadContact(sql, 2);

            //UpdateContact(sql);

            // RemovePhoneNumberFromContact(sql, 3, 1002);
            RemovePhoneNumberFromContact(sql, 1, 1);

            ReadAllContacts(sql);

            Console.WriteLine("Done Processing SQLite");

            Console.ReadLine();
        }

        private static void RemovePhoneNumberFromContact(SqliteCrud sql, int contactId, int phoneNumberId)
        {
            sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
        }

        private static void UpdateContact(SqliteCrud sql)
        {
            BasicContactModel contact = new BasicContactModel
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            sql.UpdateContactName(contact);
        }

        private static void CreateNewContact(SqliteCrud sql)
        {
            FullContactModel user = new FullContactModel
            {
                BasicInfo = new BasicContactModel
                {
                    FirstName = "Hannah",
                    LastName = "Banana"
                }
            };

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
            user.EmailAddresses.Add(new EmailAddressModel { Id = 2, EmailAddress = "me@John.com" });

            user.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "555-1212" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

            sql.CreateContact(user);
        }

        private static void ReadAllContacts(SqliteCrud sql)
        {
            var rows = sql.GetAllContacts();

            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
            }
        }

        private static void ReadContact(SqliteCrud sql, int contactId)
        {
            var contact = sql.GetFullContactById(contactId);

            Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            // to install the ConfigurationBuilder object, you need to go to the Nuget Package.
            // to do that, right click on the dependencies
            // and search for "Microsoft.Extensions.Configuration.json"
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }
    }
}
