namespace Domain.Models
{
    public class Message : BaseModel
    {
        public DateTime SendDate { get; set; }
        public string Content { get; set; }
        public Guid SenderId { get; set; }
        public AppUser Sender { get; set; }
        public Guid BookId { get; set; }
    }
}
