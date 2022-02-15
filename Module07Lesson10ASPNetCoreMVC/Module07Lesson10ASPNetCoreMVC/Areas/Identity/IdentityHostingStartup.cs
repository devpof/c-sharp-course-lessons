using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module07Lesson10ASPNetCoreMVC.Areas.Identity.Data;
using Module07Lesson10ASPNetCoreMVC.Data;

[assembly: HostingStartup(typeof(Module07Lesson10ASPNetCoreMVC.Areas.Identity.IdentityHostingStartup))]
namespace Module07Lesson10ASPNetCoreMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Module07Lesson10ASPNetCoreMVCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Module07Lesson10ASPNetCoreMVCContextConnection")));

                services.AddDefaultIdentity<Module07Lesson10ASPNetCoreMVCUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Module07Lesson10ASPNetCoreMVCContext>();
            });
        }
    }
}