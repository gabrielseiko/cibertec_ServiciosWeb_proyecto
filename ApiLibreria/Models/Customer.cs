﻿namespace ApiLibreria.Models
{
    public class Customer
    {
        public string? IdCustomer { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Dni { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }
}
