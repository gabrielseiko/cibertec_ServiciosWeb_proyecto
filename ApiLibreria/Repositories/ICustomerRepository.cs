using ApiLibreria.Models;

namespace ApiLibreria.Repositories
{
    public interface ICustomerRepository
    {
        //CRUD
        public Task<IEnumerable<Customer>> GetCustomers();
        public Task<Customer> GetCustomerById(string IdCustomer);
        public Task<Customer> CreateCustomer(Customer customer);
        public Task<Customer> UpdateCustomer(Customer customer);
        public Task<bool> DeleteCustomer(string IdCustomer); 

    }
}
