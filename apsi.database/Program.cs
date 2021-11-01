using System;
using Apsi.Database.Entities;
using GenFu;

namespace Apsi.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseSeeder.Seed();
            Console.WriteLine("Database has been seeded!");
        }
    }
}
