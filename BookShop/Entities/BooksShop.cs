namespace BookShop.Entities
{
    public class BooksShop
    {
        public int BookId { get; set; }
        public int ShopId { get; set; }
        public Book Book { get; set; }
        public Shop Shop { get; set; }
    }
}
