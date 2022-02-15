using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Module08Lesson10CosmosDB
{
    class Program
    {
        private static CosmosDBDataAccess db;

        static async Task Main(string[] args)
        {
            var c = GetCosmosInfo();

            db = new CosmosDBDataAccess(c.endpointUrl, c.primaryKey, c.databaseName, c.containerName);

            ContactModel user = new ContactModel
            {
                FirstName = "John",
                LastName = "Doe"
            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "John@iamJohn.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@John.com" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1234" });

            ContactModel user2 = new ContactModel
            {
                FirstName = "Ah-Joong",
                LastName = "Kim-Doe"
            };
            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "ahjoong@kim.com" });
            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@John.com" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

            //await CreateContact(user);
            //await CreateContact(user2);

            //await GetAllContacts();

            //await GetContactById("154c90f1-4be4-41cb-b53c-a934fa220184");

            //await UpdateContactsFirstName("poporing", "154c90f1-4be4-41cb-b53c-a934fa220184");
            //await GetContactById("154c90f1-4be4-41cb-b53c-a934fa220184");

            //await RemovePhoneNumberFromUser("555-1212", "154c90f1-4be4-41cb-b53c-a934fa220184");

            //await RemoveUser("154c90f1-4be4-41cb-b53c-a934fa220184", "Doe");

            Console.WriteLine("Done Processing CosmosDB");
            Console.ReadLine();
        }

        public static async Task RemoveUser(string id, string lastName)
        {
            await db.DeleteRecordAsync<ContactModel>(id, lastName);
        }

        public static async Task RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            await db.UpsertRecordAsync(contact);
        }

        private static async Task UpdateContactsFirstName(string firstName, string id)
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

            contact.FirstName = firstName;

            await db.UpsertRecordAsync(contact);
        }

        private static async Task GetContactById(string id) //use string or Guid
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id);

            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
        }

        private static async Task GetAllContacts()
        {
            var contacts = await db.LoadRecordsAsync<ContactModel>();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            }
        }

        private static async Task CreateContact(ContactModel contact)
        {
            await db.UpsertRecordAsync(contact);
        }

        private static (string endpointUrl, string primaryKey, string databaseName, string containerName) GetCosmosInfo()
        {
            (string endpointUrl, string primaryKey, string databaseName, string containerName) output;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            // the GetValue requires the Binder nuget package. It allows us to get values out of our appsettings.json easier
            output.endpointUrl = config.GetValue<string>("CosmosDB:EndpointUrl");
            output.primaryKey = config.GetValue<string>("CosmosDB:PrimaryKey");
            output.databaseName = config.GetValue<string>("CosmosDB:DatabaseName");
            output.containerName = config.GetValue<string>("CosmosDB:ContainerName");

            return output;
        }
    }
}
