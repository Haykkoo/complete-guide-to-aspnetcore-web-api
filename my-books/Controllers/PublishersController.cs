using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly PublishersService _publishersService;

        public PublishersController(PublishersService publishersService)
        {
            _publishersService = publishersService;
        }
        [HttpPost("Add-Publisher")]
        public IActionResult AddBook([FromBody] PublishersVM publisherVM)
        {
            _publishersService.AddPublisher(publisherVM);
            return Ok();
        }

        [HttpDelete("Delete-Publisher-by-id/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            _publishersService.DeletePublisherById(id);
            return Ok();
        }

    }
}
