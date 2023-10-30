using ApiCustomer.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCustomer.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

    }
}
