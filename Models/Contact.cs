using System.Text.Json.Serialization;

namespace CRMSystem.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
        public int LeadId { get; set; }
        public Lead? Lead { get; set; } = null!;

       
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        
        public int? AssignedToUserId { get; set; }
        public User? AssignedToUser { get; set; }

        
    }
}
