using Microsoft.AspNetCore.Mvc;

namespace Ej4controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet("{numero1}")]
        public IActionResult Get(int numero1, int num)
        {
            int mayor = numero1 > num ? numero1 : num;
            return Ok(mayor);
        }
    }
}