namespace Min.Entities.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsSended { get; set; }
        public int Attempts { get; set; }
    }
}
