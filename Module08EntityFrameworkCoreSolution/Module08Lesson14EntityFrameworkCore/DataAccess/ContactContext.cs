using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using Module08Lesson14EntityFrameworkCore.Models;

namespace Module08Lesson14EntityFrameworkCore.DataAccess
{
    // This is the application that configures the Entity Framework
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
        public DbSet<Phone> PhoneNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();

            // This is from the NuGet package Microsoft.EntityFrameworkCore.SqlServer
            options.UseSqlServer(config.GetConnectionString("Default"));
        }
    }
}
