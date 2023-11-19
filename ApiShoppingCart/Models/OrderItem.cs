using System.ComponentModel.DataAnnotations;

namespace ApiShoppingCart.Models
{
    public class OrderItem
    {
        [Key]
        public int IdOrderItem{ get; set; }
        public string? IdBook { get; set; }
        public string? Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public string? IdOrder { get; set; }
        public Order? Order { get; set; }
    }
}
