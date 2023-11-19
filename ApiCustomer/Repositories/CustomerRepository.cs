using ApiCustomer.DbContexts;
using ApiCustomer.Exceptions;
using ApiCustomer.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCustomer.Repositories
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

        public async Task<bool> DeleteCustomer(int idCustomer)
        {
            var customer = await dbContext.Customers.FirstOrDefaultAsync(c => c.IdCustomer == idCustomer);
            if (customer == null)
            {
                return false;
            }
            dbContext.Customers.Remove(customer);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Customer> GetCustomerById(int idCustomer)
        {
            var customer = await dbContext.Customers.Where(c => c.IdCustomer == idCustomer).FirstOrDefaultAsync();
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await dbContext.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetCustomers(int page, int size)
        {
            var result = await dbContext.Customers
                .Skip(page * size)
                .Take(size)
                .ToListAsync();
            if (result == null)
            {
                throw new Exception();
            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Customer list is empty");
            }
            return result;
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            dbContext.Customers.Update(customer);
            await dbContext.SaveChangesAsync();
            return customer;
        }
    }
}
