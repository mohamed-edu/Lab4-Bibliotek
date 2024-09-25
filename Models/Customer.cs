using System.ComponentModel.DataAnnotations;

namespace Lab4_Bibliotek.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public ICollection<Book>? Books { get; set; }
    }
}
