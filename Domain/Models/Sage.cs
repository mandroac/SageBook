using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Sage
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public byte[] Photo { get; set; }

        [Required, MaxLength(100)]
        public string City { get; set; }

        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, City: {City}, Id: {Id}";
        }
    }
}