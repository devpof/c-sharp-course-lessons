using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class MySqlCrud
    {
        private readonly string _connectionString;
        private MySqlDataAccess db = new MySqlDataAccess();

        public MySqlCrud(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "SELECT Id, FirstName, LastName FROM Contacts";

            // dynamic is a keyword that means any object, this way you can use the new {}
            // in the 2nd parameter if you do not have any sqlParameters.
            // new{} is an anonymous object
            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
        }

        public FullContactModel GetFullContactById(int id)
        {
            // @Id is a parameterized SQL statement. You do not want to build a string
            string sql = "SELECT Id, FirstName, LastName FROM Contacts where Id = @Id";
            FullContactModel output = new FullContactModel();

            output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault();
            if (output.BasicInfo == null)
            {
                // do something to tell the user that the record was not found
                // you can do one of the following. Exceptions are not a bad thing.
                // case to case (based on this project) we prefer to return null
                // throw new Exception("User not found");
                return null;
            }

            // allow multine line string using @ symbol. It does takes into account all the
            // whitespaces between the ""
            sql = @"SELECT E.*
                    FROM
	                    EmailAddresses AS E INNER JOIN
	                    ContactEmail AS CE
		                    ON CE.EmailAddressId = E.Id
                    WHERE CE.ContactId = @Id";

            output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

            sql = @"SELECT P.*
                    FROM
	                    PhoneNumbers AS P INNER JOIN
	                    ContactPhoneNumbers AS CP
		                    ON CP.PhoneNumberId = P.Id
                    WHERE CP.ContactId = @Id";

            output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, _connectionString);

            return output;
        }

        public void CreateContact(FullContactModel contact)
        {
            // Save the basic contact
            // You can simplify the new { ... } by inferring the member name
            // Uses the name of the property instead
            string sql = "INSERT INTO Contacts (FirstName, LastName) VALUES (@FirstName, @LastName)";
            db.SaveData(sql,
                        new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                        _connectionString);

            // Get the ID number of the contact
            sql = "SELECT Id FROM Contacts WHERE FirstName = @FirstName AND LastName = @LastName";
            int contactId = db.LoadData<IDLookupModel, dynamic>(sql,
                                                                new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                                                                _connectionString).First().Id;

            foreach (var phoneNumber in contact.PhoneNumbers)
            {
                if (phoneNumber.Id == 0)
                {
                    sql = "INSERT INTO PhoneNumbers (PhoneNumber) VALUES (@PhoneNumber)";
                    db.SaveData(sql, new { phoneNumber.PhoneNumber }, _connectionString);

                    sql = "SELECT Id FROM PhoneNumbers WHERE PhoneNumber = @PhoneNumber";
                    phoneNumber.Id = db.LoadData<IDLookupModel, dynamic>(sql,
                                                                         new { phoneNumber.PhoneNumber },
                                                                         _connectionString).First().Id;
                }

                sql = "INSERT INTO ContactPhoneNumbers (ContactId, PhoneNumberId) VALUES (@ContactId, @PhoneNumberId)";
                db.SaveData(sql, new { ContactId = contactId, PhoneNumberId = phoneNumber.Id }, _connectionString);

            }

            foreach (var email in contact.EmailAddresses)
            {
                if (email.Id == 0)
                {
                    sql = "INSERT INTO EmailAddresses (EmailAddress) VALUES (@EmailAddress)";
                    db.SaveData(sql, new { email.EmailAddress }, _connectionString);

                    sql = "SELECT Id FROM EmailAddresses WHERE EmailAddress = @EmailAddress";
                    email.Id = db.LoadData<IDLookupModel, dynamic>(sql,
                                                                   new { email.EmailAddress },
                                                                   _connectionString).First().Id;
                }

                sql = "INSERT INTO ContactEmail (ContactId, EmailAddressId) VALUES (@ContactId, @EmailAddressId)";
                db.SaveData(sql, new { ContactId = contactId, EmailAddressId = email.Id }, _connectionString);
            }
        }

        public void UpdateContactName(BasicContactModel contact)
        {
            string sql = "UPDATE Contacts SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id";
            db.SaveData(sql, contact, _connectionString);
        }

        public void RemovePhoneNumberFromContact(int contactId, int phoneNumberId)
        {
            // Find all of the usages of the phone number id
            // If 1, then delete link and phone number
            // If > 1, then delete link for contact

            string sql = "SELECT Id, ContactId, PhoneNumberId FROM ContactPhoneNumbers WHERE PhoneNumberId = @PhoneNumberId";
            var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);

            sql = "DELETE FROM ContactPhoneNumbers WHERE PhoneNumberId = @PhoneNumberId AND ContactId = @ContactId";
            db.SaveData(sql, new { PhoneNumberId = phoneNumberId, ContactId = contactId }, _connectionString);

            if (links.Count == 1)
            {
                sql = "DELETE FROM PhoneNumbers WHERE Id = @Id";
                db.SaveData(sql, new { Id = phoneNumberId }, _connectionString);
            }
        }
    }
}
