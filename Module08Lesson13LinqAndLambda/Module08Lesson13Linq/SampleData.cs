using Module08Lesson13Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Lesson13LinqAndLambda
{
    public static class SampleData
    {
        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> output = new List<ContactModel>
            {
                new ContactModel { Id = 1, FirstName = "John", LastName = "Doe", Addresses = new List<int> {1,2,3}},
                new ContactModel { Id = 2, FirstName = "Ah-joong", LastName = "Kim", Addresses = new List<int> {4,5,6}},
                new ContactModel { Id = 3, FirstName = "Ah-joong", LastName = "Doe", Addresses = new List<int> {7,8,9}},
                new ContactModel { Id = 4, FirstName = "John", LastName = "Albert", Addresses = new List<int> {10}},
                new ContactModel { Id = 5, FirstName = "John Ah-joong", LastName = "Kim-Doe", Addresses = new List<int> {11}}
            };

            return output;
        }

        public static List<AddressModel> GetAddressData()
        {
            List<AddressModel> output = new List<AddressModel>
            {
                new AddressModel {Id = 1, ContactId = 1, City = "Los Angeles", State = "CA"},
                new AddressModel {Id = 2, ContactId = 1, City = "Seoul", State = "KR"},
                new AddressModel {Id = 3, ContactId = 1, City = "New York", State = "NY"},
                new AddressModel {Id = 4, ContactId = 2, City = "Los Angeles", State = "CA"},
                new AddressModel {Id = 5, ContactId = 2, City = "Seoul", State = "KR"},
                new AddressModel {Id = 6, ContactId = 2, City = "New York", State = "NY"},
                new AddressModel {Id = 7, ContactId = 3, City = "Los Angeles", State = "CA"},
                new AddressModel {Id = 8, ContactId = 3, City = "Seoul", State = "KR"},
                new AddressModel {Id = 9, ContactId = 3, City = "New York", State = "NY"},
                new AddressModel {Id = 10, ContactId = 4, City = "Los Angeles", State = "CA"},
                new AddressModel {Id = 11, ContactId = 5, City = "Seoul", State = "KR"}
            };

            return output;
        }
    }
}
