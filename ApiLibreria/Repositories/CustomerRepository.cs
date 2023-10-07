using ApiLibreria.DbContexts;
using ApiLibreria.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLibreria.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {

        private readonly AppDbContext dbContext;
        public CustomerRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            dbContext.Customers.Add(customer);
            await dbContext.SaveChangesAsync();
            return customer;
        }

        public async Task<bool> DeleteCustomer(string IdCustomer)
        {
            var customer = await dbContext.Customers.FirstOrDefaultAsync(p => p.IdCustomer == IdCustomer);
            if (customer == null)
            {
                return false;
            }
            dbContext.Customers.Remove(customer);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Customer> GetCustomerById(string IdCustomer)
        {
            var customer = await dbContext.Customers.Where(p => p.IdCustomer == IdCustomer).FirstOrDefaultAsync();
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await dbContext.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            dbContext.Customers.Update(customer);
            await dbContext.SaveChangesAsync();
            return customer;
        }
    }
}
