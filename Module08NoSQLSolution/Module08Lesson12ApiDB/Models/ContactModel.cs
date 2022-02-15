﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module08Lesson12ApiDB.Models
{
    public class ContactModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EmailAddressModel> EmailAddresses { get; set; } = new List<EmailAddressModel>();
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();
    }
}