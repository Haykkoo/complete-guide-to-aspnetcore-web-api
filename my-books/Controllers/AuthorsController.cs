using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsService;

        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }
        [HttpPost("Add-Author")]
        public IActionResult AddAuthor([FromBody] AuthorVM authorVM)
        {
            _authorsService.AddAuthor(authorVM);
            return Ok();
        }
        [HttpGet("get-Author-books-by-/{id}")]
        public IActionResult GetAuthorWithBook(int id)
        {
            var response = _authorsService.GetAuthorWithBooks(id);
            return Ok(response);
        }


    }
}
