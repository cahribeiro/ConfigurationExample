using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers
{
    public class ExampleController : Controller
    {
        private readonly ExampleSettings _settings;

        public ExampleController(IOptions<ExampleSettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet("example")]
        public IActionResult Index()
        {
            return Ok(new
            {
                fromOption = _settings.ConnectionString
            });
        }
    }
}
