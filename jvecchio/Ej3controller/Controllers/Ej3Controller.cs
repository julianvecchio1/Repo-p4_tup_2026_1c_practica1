using Microsoft.AspNetCore.Mvc;

namespace Ej3controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet("{edad}")]
        public IActionResult Get(int edad, string nombre)
        {
            string mensaje = $"Te llamas {nombre} y tienes {edad} años";
            return Ok(mensaje);
        }
    }
}