using ApiShoppingCart.DbContexts;
using ApiShoppingCart.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiShoppingCart.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly AppDbContext dbContext;
        public CartRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> PlaceOrder(Order order)
        {
            try
            {
                dbContext.Orders.Add(order);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                // grabar logs
                return false;
            }
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await dbContext.Orders.ToListAsync();
        }
        public async Task<Order> GetOrderByCustomer(string idCustomer)
        {
            var order = await dbContext.Orders.Where(o => o.IdCustomer == idCustomer).FirstOrDefaultAsync();
            return order;
        }

        public async Task<Order> GetOrderByEmployee(string idEmployee)
        {
            var order = await dbContext.Orders.Where(o => o.IdEmployee == idEmployee).FirstOrDefaultAsync();
            return order;
        }

        public async Task<Order> GetOrderById(string idOrder)
        {
            var order = await dbContext.Orders.Where(o => o.IdOrder == idOrder).FirstOrDefaultAsync();
            return order;
        }

        

        
    }
}
