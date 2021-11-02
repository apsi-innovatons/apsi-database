using System;
using System.Security.Principal;

namespace Apsi.Database.Entities
{
    public class Review
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
        public Idea Idea { get; set; }
        public User Author { get; set; }
    }
}