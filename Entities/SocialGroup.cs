using System.Collections.Generic;

namespace Apsi.Database.Entities
{
    public class SocialGroup
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}