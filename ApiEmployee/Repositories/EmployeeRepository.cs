using ApiEmployee.DbContexts;
using ApiEmployee.Exceptions;
using ApiEmployee.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmployee.Repositories
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
            if (employee == null)
            {
                throw new NotFoundException($"Employee not found with id {idEmployee}");
            }
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployees(int page, int size)
        {
            var result = await dbContext.Employees
                .Skip(page * size)
                .Take(size)
                .ToListAsync();
            if (result == null)
            {
                throw new Exception();
            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Employee list is empty");
            }
            return result;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }
    }
}
