using System;
using System.IO;
using Apsi.Database.Entities;
using GenFu;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Apsi.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            // connect to sql server with connection string from app settings
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
            var context = new AppDbContext(optionsBuilder.Options);
            DatabaseSeeder.Seed(context);
            Console.WriteLine("Database has been seeded!");
        }
    }
}
