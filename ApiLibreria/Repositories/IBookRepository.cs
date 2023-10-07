using ApiLibreria.Models;

namespace ApiLibreria.Repositories
{
    public interface IBookRepository
    {
        //CRUD
        public Task<IEnumerable<Book>> GetBooks();
        public Task<Book> GetBookById(string IdBook);
        public Task<Book> CreateBook(Book book);
        public Task<Book> UpdateBook(Book book);
        public Task<bool> DeleteBook(string IdBook);
    }
}
