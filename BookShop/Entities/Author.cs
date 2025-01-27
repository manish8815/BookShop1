using System.ComponentModel.DataAnnotations;

namespace BookShop.Entities
{
    public class Author
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Author Name required")]
        public required string Name { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string? Biography { get; set; }
        public string? Picture { get; set; }

    }
}
