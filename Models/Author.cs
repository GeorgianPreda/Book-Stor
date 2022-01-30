
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models

{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Added Date and Time")]
        public DateTime AddedDateTime { get; set; } = DateTime.Now;
        public List<Book> Books { get; set; }
    }
}
