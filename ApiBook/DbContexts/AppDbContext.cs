using ApiBook.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBook.DbContexts
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
    }
}
