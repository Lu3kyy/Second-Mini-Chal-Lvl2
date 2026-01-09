using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet("reversealphanumeric")]
        public IActionResult ReverseAlphanumeric([FromQuery] string input)
        {
            var result = _service.ReverseAlphanumeric(input);
            return Ok(result);
        }
    }
}
