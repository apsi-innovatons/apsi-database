using System;
using System.Collections.Generic;
using Apsi.Database.Entities.Enums;

namespace Apsi.Database.Entities
{
    public class Idea
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public string StatusDescription { get; set; }
        public DateTime Date { get; set; }
        public bool Blocked { get; set; }
        public bool Anonymous { get; set; }

        public Subject Subject { get; set; }
        public List<RatingSetting> RatingSettings { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<Benefit> Benefits { get; set; }
        public List<Cost> Costs { get; set; }
        public User Author { get; set; }
    }
}