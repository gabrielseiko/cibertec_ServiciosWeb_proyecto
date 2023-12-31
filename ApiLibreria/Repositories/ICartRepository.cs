﻿using ApiLibreria.Models;

namespace ApiLibreria.Repositories
{
    public interface ICartRepository
    {
        public Task<bool> PlaceOrder(Order order);

        public Task<IEnumerable<Order>> GetOrders();
        public Task<Order> GetOrderById(string idOrder);
        public Task<Order> GetOrderByCustomer(string idCustomer);
        public Task<Order> GetOrderByEmployee(string idEmployee);

    }
}
