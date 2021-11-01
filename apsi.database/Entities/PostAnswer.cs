using System;

namespace Apsi.Database.Entities
{
    public class PostAnswer
    {
        public int? Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public User Author { get; set; }
    }
}