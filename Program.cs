using System;
using System.IO;
using Apsi.Database.Entities;
using GenFu;
using Microsoft.Extensions.Configuration;

namespace Apsi.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            DatabaseSeeder.Seed(context);
            Console.WriteLine("Database has been seeded!");
        }
    }
}
