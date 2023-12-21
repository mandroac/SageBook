namespace Domain.Models
{
    public class UserMessage : Message
    {
        public Guid ReceiverId { get; set; }
        public AppUser Receiver { get; set; }
    }
}
