using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public readonly BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] BookVM bookVM)
        {
            _booksService.AddBook(bookVM);
            return Ok();
        }
        [HttpGet("get-All-books")]
        public IActionResult ActionResultGetAllBooks()
        {
            var allBooks = _booksService.GetBooks();
            return Ok(allBooks);
        }

        [HttpGet("get-book-by-id/{bookid}")]
        public IActionResult GetBookById(int bookid)
        {
            var book = _booksService.GetBookById(bookid);
            return Ok(book);
        }

        [HttpPut("Update- Book-By-Id/{id}")]
        public IActionResult UpdateBook(int id, [FromBody] BookVM bookVM)
        {
            var book = _booksService.UpdateBookById(id, bookVM);
            return Ok(book);
        }
        [HttpDelete("Remove-Book-From_DB/{id}")]
        public IActionResult RemoveBookById(int id)
        {
            _booksService.RemoveBookById(id);
            return Ok();
        }

    }
}
