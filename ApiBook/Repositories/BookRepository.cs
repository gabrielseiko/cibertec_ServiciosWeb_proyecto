using ApiBook.Models;
using ApiBook.DbContexts;
using Microsoft.EntityFrameworkCore;
using ApiBook.Exceptions;

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

        public async Task<bool> DeleteBook(int idBook)
        {
            var book = await dbContext.Books.FirstOrDefaultAsync(b => b.IdBook == idBook);
            if(book == null)
            {
                return false;
            }
            dbContext.Books.Remove(book);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Book> GetBookById(int idBook)
        {
            var book = await dbContext.Books.Where(b => b.IdBook == idBook).FirstOrDefaultAsync();
            return book;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await dbContext.Books.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooks(int page, int size)
        {
            var result = await dbContext.Books
                .Skip(page * size)
                .Take(size)
                .ToListAsync();
            if (result == null)
            {
                throw new Exception();
            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Book list is empty");
            }
            return result;
        }

        public async Task<Book> UpdateBook(Book book)
        {
            dbContext.Books.Update(book);
            await dbContext.SaveChangesAsync();
            return book;
        }
    }
}
