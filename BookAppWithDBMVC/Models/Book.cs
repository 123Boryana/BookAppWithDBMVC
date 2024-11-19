using System.ComponentModel.DataAnnotations;

namespace BookAppWithDBMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Author cannot be longer than 50 characters.")]
        public string Author { get; set; }

        [Range(1450, 2100, ErrorMessage = "Year must be between 1450 and 2100.")]
        public int YearPublished { get; set; }
    }
}
