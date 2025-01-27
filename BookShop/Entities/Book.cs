using System.ComponentModel.DataAnnotations;

namespace BookShop.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(maximumLength:100)]
        public required string  Title { get; set; }
        public string  Summary { get; set; }
        public string  Cover { get; set; }
        public bool IsAvailable {  get; set; }
        public DateTime  PublishDate { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<BookCategory> BoolCategories { get; set; }
        public List<BooksShop> BookShops { get; set; }
    }
}
