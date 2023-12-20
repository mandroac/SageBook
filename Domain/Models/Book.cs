using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Book : BaseModel
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }
        public ICollection<Sage> Sages { get; set; }
        public ICollection<Message> Messages { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}";
        }
    }
}
