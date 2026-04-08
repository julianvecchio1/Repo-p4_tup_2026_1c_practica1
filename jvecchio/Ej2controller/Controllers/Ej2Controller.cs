using Microsoft.AspNetCore.Mvc;

namespace Ej2controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet("{nombre}/{ciudad}")]
        public IActionResult Get(string nombre, string ciudad)
        {
            string mensaje = $"Hola {nombre} bienvenido a {ciudad}";
            return Ok(mensaje);
        }
    }
}