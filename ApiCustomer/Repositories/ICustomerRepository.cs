using ApiCustomer.Models;

namespace ApiCustomer.Repositories
{
    public interface ICustomerRepository
    {
        //CRUD
        public Task<IEnumerable<Customer>> GetCustomers();
        public Task<IEnumerable<Customer>> GetCustomers(int page, int size);
        public Task<Customer> GetCustomerById(string idCustomer);
        public Task<Customer> CreateCustomer(Customer customer);
        public Task<Customer> UpdateCustomer(Customer customer);
        public Task<bool> DeleteCustomer(string idCustomer);
    }
}
