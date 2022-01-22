namespace Apsi.Database.Entities
{
    public class Vote
    {
        public int? Id { get; set; }
        // values from 5 to 1 if normal voting, 0\1 if noncategorized voting
        public int Value { get; set; }
        public User CommitteeMember { get; set; }
    }
}