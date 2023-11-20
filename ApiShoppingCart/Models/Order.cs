using System.ComponentModel.DataAnnotations;

namespace ApiShoppingCart.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string? CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
