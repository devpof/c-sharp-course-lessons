using Module08Lesson14EntityFrameworkCore.DataAccess;
using Module08Lesson14EntityFrameworkCore.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Module08Lesson14EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateMe();
            //CreateAhJoong();
            ReadAll();
            //ReadById(1);
            //UpdateFirstName(1, "John Doe");
            //RemovePhoneNumber(1, "555-1234");
            //RemoveUser(1);
            ReadAll();

            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        private static void CreateMe()
        {
            var c = new Contact
            {
                FirstName = "John",
                LastName = "Doe"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "John@iamJohn.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "me@Doe.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1234" });

            // established a connection
            // the connection to the db will end at the last brace
            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void CreateAhJoong()
        {
            var c = new Contact
            {
                FirstName = "Ah-Joong",
                LastName = "Doe"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "ahjoong@iamahjoong.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "me@Doe.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-9876" });

            // established a connection
            // the connection to the db will end at the last brace
            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                // this only grabs the Contacts table and not the Email Address/Phone Numbers
                // var records = db.Contacts.ToList();

                // including tables will have this create one whole query to grab all of the records.
                var records = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .ToList();


                foreach (var c in records)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName}");
                }
            }
        }

        private static void ReadById(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }

        private static void UpdateFirstName(int id, string firstName)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                user.FirstName = firstName;

                db.SaveChanges();
            }
        }

        private static void RemovePhoneNumber(int id, string phoneNumber)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id)
                    .First();

                // by default the phone number record in the table will have a NULL value on the ContactID column.
                // EF designed this by default in the Migration script
                user.PhoneNumbers.RemoveAll(p => p.PhoneNumber == phoneNumber);

                db.SaveChanges();
            }
        }

        private static void RemoveUser(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id)
                    .First();


                db.Contacts.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
