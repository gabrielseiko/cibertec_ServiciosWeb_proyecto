using ApiEmployee.Models;

namespace ApiEmployee.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<IEnumerable<Employee>> GetEmployees(int page, int size);
        public Task<Employee> GetEmployeeById(int idEmployee);
        public Task<Employee> CreateEmployee(Employee employee);
        public Task<Employee> UpdateEmployee(Employee employee);
        public Task<bool> DeleteEmployee(int idEmployee);
    }
}
