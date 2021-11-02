using System;
using System.Collections.Generic;

namespace Apsi.Database.Entities
{
    public class Post
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public SocialGroup SocialGroup { get; set; }
        public User Author { get; set; }
        public List<PostAnswer> PostAnswers { get; set; }
    }
}