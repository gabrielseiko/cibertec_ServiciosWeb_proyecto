using ApiLibreria.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLibreria.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books {get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
