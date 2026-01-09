using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompareController : ControllerBase
    {
        private readonly ICompareService _service;

        public CompareController(ICompareService service)
        {
            _service = service;
        }

        [HttpGet("oddoreven")]
        public IActionResult OddOrEven([FromQuery] int number)
        {
            var result = _service.OddOrEven(number);
            return Ok(result);
        }

        [HttpGet("reversenumbers")]
        public IActionResult ReverseNumbers([FromQuery] string numbers)
        {
            var result = _service.ReverseNumbers(numbers);
            return Ok(result);
        }
    }
}
