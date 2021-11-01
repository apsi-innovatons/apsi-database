using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Apsi.Database.Entities;
using Apsi.Database.Entities.Enums;
using GenFu;


namespace Apsi.Database
{
    public static class DatabaseSeeder
    {
        public static void Seed()
        {
            var context = new AppDbContext();

            context.Users.Add(new User()
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                Password = "1234567890",
                Username = "student",
                UserRole = UserRole.Student
            });

            context.Users.Add(new User()
            {
                FirstName = "Janusz",
                LastName = "Nowak",
                Password = "1234567890",
                Username = "committee",
                UserRole = UserRole.Committee
            });

            context.Users.Add(new User()
            {
                FirstName = "Janusz",
                LastName = "Nowak",
                Password = "1234567890",
                Username = "employee",
                UserRole = UserRole.Employee
            });

            context.Users.Add(new User()
            {
                FirstName = "Janina",
                LastName = "Jędrzejczak",
                Password = "1234567890",
                Username = "admin",
                UserRole = UserRole.Admin
            });

            context.Users.Add(new User()
            {
                FirstName = "Zofia",
                LastName = "Kruk",
                Password = "1234567890",
                Username = "student",
                UserRole = UserRole.Employee
            });

            A.Configure<Attachment>()
                .Fill(x => x.Id, (int?)null);

            A.Configure<Benefit>()
                .Fill(x => x.Id, (int?)null)
                .Fill(x => x.Description).AsLoremIpsumSentences(4);
            

            A.Configure<Cost>()
                .Fill(x => x.Id, (int?)null);

            A.Configure<RatingSetting>()
                .Fill(x => x.Id, (int?)null);

            A.Configure<SocialGroup>()
                .Fill(x => x.Id, (int?)null);

            A.Configure<Subject>()
                .Fill(x => x.Id, (int?)null);

            var socialGroups = A.ListOf<SocialGroup>(10);
            A.Configure<User>()
                .Fill(x => x.Id, (int?) null)
                .Fill(x => x.Password, "1234567890")
                .Fill(x => x.SocialGroups)
                .AsRandom(socialGroups, 1, 4);

            var genUsers = A.ListOf<User>(40);
            context.AddRange(genUsers);

            var subjects = A.ListOf<Subject>();
            A.Configure<Idea>()
                .Fill(x => x.Id, (int?)null)
                .Fill(x => x.Benefits, A.ListOf<Benefit>())
                .Fill(x => x.Attachments, A.ListOf<Attachment>())
                .Fill(x => x.Costs, A.ListOf<Cost>())
                .Fill(x => x.Subject).WithRandom(subjects)
                .Fill(x => x.RatingSettings, A.ListOf<RatingSetting>(3))
                .Fill(x => x.Author).WithRandom(genUsers)
                .Fill(x => x.Description).AsLoremIpsumSentences(4);

            var ideas = A.ListOf<Idea>(35);
            context.AddRange(ideas);

            A.Configure<PostAnswer>()
                .Fill(x => x.Id, (int?)null)
                .Fill(x => x.Author).WithRandom(genUsers)
                .Fill(x => x.Text).AsLoremIpsumSentences(4);

            A.Configure<Post>()
                .Fill(x => x.Id, (int?)null)
                .Fill(x => x.PostAnswers, A.ListOf<PostAnswer>())
                .Fill(x => x.Author).WithRandom(genUsers)
                .Fill(x => x.SocialGroup).WithRandom(socialGroups)
                .Fill(x => x.Text).AsLoremIpsumSentences(4);

            var posts = A.ListOf<Post>(30);

            context.AddRange(posts);

            A.Configure<Review>()
                .Fill(x => x.Id, (int?)null)
                .Fill(x => x.Idea).WithRandom(ideas)
                .Fill(x => x.Description).AsLoremIpsumSentences(4);
            var reviews = A.ListOf<Review>(50);

            context.AddRange(reviews);

            context.SaveChanges();
        }


    }
}