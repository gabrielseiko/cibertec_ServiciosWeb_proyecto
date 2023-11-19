using ApiBook.Models;
using ApiLibreria.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiBook.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BookController : ControllerBase

    {
        private readonly IBookRepository bookRepository;
       public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("GetBooks")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return StatusCode(StatusCodes.Status200OK, await bookRepository.GetBooks());
        }

        [HttpGet]
        [Route("GetBooks/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK, await bookRepository.GetBooks(page, size));
        }

        [HttpGet]
        [Route("GetBookById/{idBook}")]
        public async Task<ActionResult<Book>> GetBookById(int idBook)
        {
            return StatusCode(StatusCodes.Status200OK, await bookRepository.GetBookById(idBook));
        }

        [HttpPost]
        [Route("CreateBook")]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
            return StatusCode(StatusCodes.Status201Created, await bookRepository.CreateBook(book));
        }

        [HttpPut]
        [Route("UpdateBook")]
        public async Task<ActionResult<Book>> UpdateCategory(Book book)
        {
            return StatusCode(StatusCodes.Status200OK, await bookRepository.UpdateBook(book));
        }

        [HttpDelete]
        [Route("DeleteBook")]
        public async Task<ActionResult<bool>> DeleteBook(int idBook)
        {
            return StatusCode(StatusCodes.Status200OK, await bookRepository.DeleteBook(idBook));
        }
    }
}
