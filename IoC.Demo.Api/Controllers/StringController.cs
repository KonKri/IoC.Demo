using IoC.Demo.StringManipulation.Services;
using Microsoft.AspNetCore.Mvc;

namespace IoC.Demo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringController : ControllerBase
    {
        private readonly IStringManipulationService _charManipulatorService;

        public StringController(IStringManipulationService charManipulatorService)
        {
            _charManipulatorService = charManipulatorService;
        }

        [HttpGet(Name = "Manipulate String with prefix and suffix")]
        public IActionResult Get([FromQuery] string phrase = "The quick fox jumps over the lazy dog")
        {
            // manipulate existing phrase.
            _charManipulatorService.ManipulateStr(ref phrase);

            return Ok(phrase);
        }
    }
}