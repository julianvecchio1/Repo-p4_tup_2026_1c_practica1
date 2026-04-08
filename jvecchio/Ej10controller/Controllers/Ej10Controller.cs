using Microsoft.AspNetCore.Mvc;

namespace Ej10controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej10Controller : ControllerBase
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

                List<int> pares = new List<int>();
                List<int> impares = new List<int>();

                for (int i = inicio; i <= fin; i++)
                {
                    if (i % 2 == 0)
                    {
                        pares.Add(i);
                    }
                    else
                    {
                        impares.Add(i);
                    }
                }

                // Retornar ambas listas
                return Ok(new
                {
                    Pares = pares,
                    Impares = impares
                });
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}