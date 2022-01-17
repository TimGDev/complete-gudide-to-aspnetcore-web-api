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
        public PublishersService _PublishersService;

        public PublishersController(PublishersService PublishersService)
        {
            _PublishersService = PublishersService;
        }
        [HttpPost("add-pubisher")]
        public IActionResult AddBook([FromBody] PublisherVM publisher)
        {
            _PublishersService.AddPublisher(publisher);
            return Ok();
        }
    }
}
