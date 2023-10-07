using ApiLibreria.Models;
using ApiLibreria.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace ApiLibreria.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext dbContext;
        public BookRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }

        public async Task<Book> CreateBook(Book book)
        {
            dbContext.Books.Add(book);
            await dbContext.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteBook(string IdBook)
        {
            var book = await dbContext.Books.FirstOrDefaultAsync(p => p.IdBook == IdBook);
            if(book == null)
            {
                return false;
            }
            dbContext.Books.Remove(book);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Book> GetBookById(string IdBook)
        {
            var book = await dbContext.Books.Where(p => p.IdBook == IdBook).FirstOrDefaultAsync();
            return book;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await dbContext.Books.ToListAsync();
        }

        public async Task<Book> UpdateBook(Book book)
        {
            dbContext.Books.Update(book);
            await dbContext.SaveChangesAsync();
            return book;
        }
    }
}
