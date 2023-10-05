namespace ApiLibreria.Models
{
    public class Book
    {
        public string? IdBook { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? IdCategory { get; set; }
        public Category? Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
