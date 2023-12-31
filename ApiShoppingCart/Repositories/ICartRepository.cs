﻿using ApiShoppingCart.Models;

namespace ApiShoppingCart.Repositories
{
    public interface ICartRepository
    {
        public Task<bool> PlaceOrder(Order order);

        public Task<IEnumerable<Order>> GetOrders();
        public Task<Order> GetOrderById(int idOrder);
        public Task<Order> GetOrderByCustomer(int idCustomer);
    }
}
