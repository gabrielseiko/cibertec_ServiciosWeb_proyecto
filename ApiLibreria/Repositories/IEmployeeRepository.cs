using ApiLibreria.Models;

namespace ApiLibreria.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployeeById(string idEmployee);
        public Task<Employee> CreateEmployee(Employee employee);
        public Task<Employee> UpdateEmployee(Employee employee);
        public Task<bool> DeleteEmployee(string idEmployee);
    }
}
