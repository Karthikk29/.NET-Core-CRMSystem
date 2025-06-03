namespace CRMSystem.Models
{
    public class Lead
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Status { get; set; } = "New"; 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

       
        public int? AssignedToUserId { get; set; }
        public User? AssignedToUser { get; set; }
    }
}
