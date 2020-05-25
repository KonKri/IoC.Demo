using IoC.Testing.Core.CharManipulationModule;
using Microsoft.AspNetCore.Mvc;

namespace IoC.Testing.WebApi.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly CharManipulatorService _charManipulatorService;

        public HomeController(CharManipulatorService charManipulatorService)
        {
            _charManipulatorService = charManipulatorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var finalWord = _charManipulatorService.Add3ACharsInTheEnd("asdf");
            return Ok(finalWord);
        }
    }
}