using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddController : ControllerBase
    {
        private readonly IAddService _service;

        public AddController(IAddService service)
        {
            _service = service;
        }

        [HttpGet("madlib")]
        public IActionResult MadLib([FromQuery] string name, [FromQuery] string place, [FromQuery] string noun, [FromQuery] string verb, [FromQuery] string adjective)
        {
            var result = _service.CreateMadLib(name, place, noun, verb, adjective);
            return Ok(result);
        }
    }
}
