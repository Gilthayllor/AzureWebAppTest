using Microsoft.AspNetCore.Mvc;

namespace AzureWebAppTest.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello World");
        }

        [HttpGet("[action]")]
        public IActionResult GetDate()
        {
            return Ok(DateTime.UtcNow);
        }
        
        [HttpGet("[action]")]
        public IActionResult GetOwner([FromServices] IConfiguration configuration)
        {
            return Ok(configuration.GetValue<string>("Owner"));
        }
    }
}
