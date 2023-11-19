namespace ApiBook.Models
{
    public class Book
    {
        public int IdBook { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? IdCategory { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }
    }
}
