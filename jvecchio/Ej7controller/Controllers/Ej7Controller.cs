using Microsoft.AspNetCore.Mvc;

namespace Ej7controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej7Controller : ControllerBase
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

                for (int i = inicio; i <= fin; i++)
                {
                    numeros.Add(i);
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