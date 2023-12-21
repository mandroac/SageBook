using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Order : BaseModel
    {
        [Required]
        public int OrderNumber { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public AppUser User { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<UserMessage> SentMessages { get; set; }
    }
}
