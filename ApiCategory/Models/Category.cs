using System.ComponentModel.DataAnnotations;

namespace ApiCategory.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string? Name { get; set; }
        

    }
}
