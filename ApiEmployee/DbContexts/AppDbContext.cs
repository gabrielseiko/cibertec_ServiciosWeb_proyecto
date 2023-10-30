using ApiEmployee.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmployee.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
