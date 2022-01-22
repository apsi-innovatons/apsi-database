using System.Collections.Generic;
using Apsi.Database.Entities.Enums;

namespace Apsi.Database.Entities
{
    public class Subject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public UserRole? Audience { get; set; }
        public List<User> CommitteeMembers { get; set; }
        public bool Done { get; set; }
    }
}