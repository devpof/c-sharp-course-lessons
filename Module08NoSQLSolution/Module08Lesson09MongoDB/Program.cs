using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace Module08Lesson09MongoDB
{
    class Program
    {
        private static MongoDBDataAccess db;
        private static readonly string tableName = "Contacts";

        [Obsolete]
        static void Main(string[] args)
        {
            db = new MongoDBDataAccess("MongoContactsDB", GetConnectionString());

            ContactModel user = new ContactModel
            {
                FirstName = "Ah-Joong",
                LastName = "Kim"
            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "ahjoong@kim.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@john.com" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

            //CreateContact(user);

            //GetAllContacts();

            //GetContactById("0965d57d-7ec8-4d65-9348-7f5ca6f9974b");

            //UpdateContactsFirstName("popo", "984b512a-4211-42f5-a25e-8f797e1b39b4");
            //GetAllContacts();

            //RemovePhoneNumberFromUser("555-1212", "984b512a-4211-42f5-a25e-8f797e1b39b4");

            RemoveUser("984b512a-4211-42f5-a25e-8f797e1b39b4"
                );

            Console.WriteLine("Done Processing MongoDB");
            Console.ReadLine();
        }

        public static void RemoveUser(string id)
        {
            Guid guid = new Guid(id);
            db.DeleteRecord<ContactModel>(tableName, guid);
        }

        [Obsolete]
        public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);

            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            db.UpsertRecord(tableName, contact.Id, contact);
        }

        [Obsolete]
        private static void UpdateContactsFirstName(string firstName, string id)
        {
            //you can use the GetContactById to grab info
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);

            contact.FirstName = firstName;

            db.UpsertRecord(tableName, contact.Id, contact);
        }

        private static void GetContactById(string id) //use string or Guid
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);

            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
        }

        private static void GetAllContacts()
        {
            var contacts = db.LoadRecords<ContactModel>(tableName);

            foreach(var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            }
        }

        [Obsolete]
        private static void CreateContact(ContactModel contact)
        {
            db.UpsertRecord(tableName, contact.Id, contact);
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }

    }
}
