using Microsoft.AspNetCore.Mvc;

namespace Ej8controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int fin)
        {
            try
            {
                int diferencia = fin - inicio;

                if (diferencia < 0 || diferencia > 1000)
                {
                    return BadRequest("La diferencia debe ser entre 0 y 1000");
                }

                List<int> numeros = new List<int>();

                int i = inicio;

                while (i <= fin)
                {
                    numeros.Add(i);
                    i++;
                }

                return Ok(numeros);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}