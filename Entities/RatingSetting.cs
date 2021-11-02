using System.Collections.Generic;
using Apsi.Database.Entities.Enums;

namespace Apsi.Database.Entities
{
    public class RatingSetting
    {
        public int? Id { get; set; }
        public UserRole UserRole { get; set; }
        public double Weight { get; set; }
    }
}