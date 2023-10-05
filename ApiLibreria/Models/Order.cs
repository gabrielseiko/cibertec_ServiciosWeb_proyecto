namespace ApiLibreria.Models
{
    public class Order
    {
        public string? IdOrder { get; set; }
        public string? IdCustomer { get; set; }
        public Customer? Customer { get; set; }
        public string? CustomerName { get; set; }
        public string? IdEmployee { get; set; }
        public Employee? Employee { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
