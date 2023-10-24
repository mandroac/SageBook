using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }
        public ICollection<Sage> Sages { get; set; }
    }
}
