namespace CRMSystem.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty; 

        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
