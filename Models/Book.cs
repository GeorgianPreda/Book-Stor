    using System.ComponentModel.DataAnnotations;
namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Added Date and Time")]
        public DateTime AddedDateTime { get; set; } = DateTime.Now;
        //public string Author { get; set; }
    }
}
