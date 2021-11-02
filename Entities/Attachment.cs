namespace Apsi.Database.Entities
{
    public class Attachment
    {
        public int? Id { get; set; }
        public string FileName { get; set; }
        public byte[] FlieBytes { get; set; }
    }
}