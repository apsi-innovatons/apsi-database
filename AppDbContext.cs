using System.IO;
using Apsi.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Apsi.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostAnswer> PostAnswers { get; set; }
        public DbSet<RatingSetting> RatingSettings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SocialGroup> SocialGroups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            options.UseSqlServer(configuration.GetConnectionString("Default"));
        }
    }
}