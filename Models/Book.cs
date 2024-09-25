using System.ComponentModel.DataAnnotations;

namespace Lab4_Bibliotek.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public bool IsReturned { get; set; } = false;
        [Required]
        public string? Author { get; set; }
        

        public ICollection<Customer>? Customers { get; set; }
    }
}
