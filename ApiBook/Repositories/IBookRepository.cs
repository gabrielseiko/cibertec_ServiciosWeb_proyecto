using ApiBook.Models;

namespace ApiLibreria.Repositories
{
    public interface IBookRepository
    {
        //CRUD
        public Task<IEnumerable<Book>> GetBooks();
        public Task<IEnumerable<Book>> GetBooks(int page, int size);
        public Task<Book> GetBookById(int idBook);
        public Task<Book> CreateBook(Book book);
        public Task<Book> UpdateBook(Book book);
        public Task<bool> DeleteBook(int idBook);
    }
}
