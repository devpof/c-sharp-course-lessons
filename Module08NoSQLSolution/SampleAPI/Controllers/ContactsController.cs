using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private MongoDBDataAccess db;
        private readonly string tableName = "Contacts";
        private readonly IConfiguration config;

        public ContactsController(IConfiguration config)
        {
            this.config = config;
            db = new MongoDBDataAccess("MongoContactsDB", this.config.GetConnectionString("Default"));
        }

        [HttpGet]
        public List<ContactModel> GetAll()
        {
            return db.LoadRecords<ContactModel>(tableName);
        }

        [HttpPost]
        [Obsolete]
        public void InsertRecord(ContactModel contact)
        {
            db.UpsertRecord(tableName, contact.Id, contact);
        }
    }
}
