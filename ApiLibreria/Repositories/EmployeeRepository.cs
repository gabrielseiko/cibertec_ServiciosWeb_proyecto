using ApiLibreria.DbContexts;
using ApiLibreria.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLibreria.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext dbContext;
        public EmployeeRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteEmployee(string idEmployee)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(e => e.IdEmployee == idEmployee);
            if (employee == null)
            {
                return false;
            }
            dbContext.Employees.Remove(employee);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Employee> GetEmployeeById(string idEmployee)
        {
            var employee = await dbContext.Employees.Where(e => e.IdEmployee == idEmployee).FirstOrDefaultAsync();
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }
    }
}
