using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HotelAppLibrary.Data;
using HotelAppLibrary.Databases;

namespace HotelApp.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ServiceProvider serviceProvider;
        // override startup method in Application class
        // custom so we are set out to have our dependency injection
        // and including our configuration all in our application
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();
            // manual way
            // adding MainWindow to dependency injection
            // adding to AddTransient to make it so you can more than one instance of MainWindow
            services.AddTransient<MainWindow>();
            services.AddTransient<CheckInForm>();
            //services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            //services.AddTransient<ISqliteDataAccess, SqliteDataAccess>();
            //services.AddTransient<IDatabaseData, SqlData>();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();

            services.AddSingleton(config);

            // dynamic way of dependency injection
            string dbChoice = config.GetValue<string>("DatabaseChoice").ToLower();
            if (dbChoice == "sql")
            {
                services.AddTransient<IDatabaseData, SqlData>();
            }
            else if (dbChoice == "sqlite")
            {
                services.AddTransient<IDatabaseData, SqliteData>();
            }
            else
            {
                // Fallback / Default value
                services.AddTransient<IDatabaseData, SqlData>();
            }

            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<ISqliteDataAccess, SqliteDataAccess>();
            // end - dynamic way of dependency injection

            serviceProvider = services.BuildServiceProvider();
            var mainWindow = serviceProvider.GetService<MainWindow>();

            mainWindow.Show();
        }
    }
}
