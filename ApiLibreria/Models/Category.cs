namespace ApiLibreria.Models
{
    public class Category
    {
        public string? IdCategory { get; set; }
        public string? Name { get; set; }
        public ICollection<Book>? Books { get; set; }

    }
}
