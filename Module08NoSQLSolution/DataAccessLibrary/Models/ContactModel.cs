using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ContactModel
    {
        // tells mongoDB that this is the ID property instead of the _id. You're basically mapping it to use this for this document.
        [BsonId] // this is for MongoDB
        [JsonProperty(PropertyName = "id")] // this is for Cosmos
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EmailAddressModel> EmailAddresses { get; set; } = new List<EmailAddressModel>();
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();

    }
}
