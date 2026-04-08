using Microsoft.AspNetCore.Mvc;

namespace Ej1controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int a, int b, int c)
        {
            return Ok(a + b + c);
        }
    }
}