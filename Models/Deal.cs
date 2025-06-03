namespace CRMSystem.Models
{
    public class Deal
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public string Stage { get; set; } = "Prospect"; 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
       public int? AssignedToUserId { get; set; }
public User? AssignedToUser { get; set; }

        
        
        public int? ContactId { get; set; }
        public Contact? Contact { get; set; }
    }
}
