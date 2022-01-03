using System;
using System.Collections.Generic;

namespace Apsi.Database.Entities
{
    public class Rating
    {
        public int? Id { get; set; }
        public double Weight { get; set; }

        public double Value { get; set; }
        public User Author { get; set; }
    }
}