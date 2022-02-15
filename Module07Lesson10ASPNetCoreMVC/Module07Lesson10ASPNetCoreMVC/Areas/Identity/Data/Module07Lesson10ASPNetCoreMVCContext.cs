using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Module07Lesson10ASPNetCoreMVC.Areas.Identity.Data;

namespace Module07Lesson10ASPNetCoreMVC.Data
{
    public class Module07Lesson10ASPNetCoreMVCContext : IdentityDbContext<Module07Lesson10ASPNetCoreMVCUser>
    {
        public Module07Lesson10ASPNetCoreMVCContext(DbContextOptions<Module07Lesson10ASPNetCoreMVCContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
