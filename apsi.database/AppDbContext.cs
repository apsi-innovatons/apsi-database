using Apsi.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apsi.Database
{
    public class AppDbContext : DbContext
    {
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:apsi.database.windows.net,1433;Initial Catalog=apsi-database;Persist Security Info=False;User ID=apsidbadmin;Password=k4p4sFUrZkwNpx8;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}