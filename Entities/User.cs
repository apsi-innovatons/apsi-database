using System.Collections.Generic;
using System.Text.RegularExpressions;
using Apsi.Database.Entities.Enums;

namespace Apsi.Database.Entities
{
    public class User
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole UserRole { get; set; }
        public string Password { get; set; }
        public List<SocialGroup> SocialGroups { get; set; }
    }
}