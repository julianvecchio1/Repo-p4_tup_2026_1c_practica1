using Microsoft.AspNetCore.Mvc;

namespace Ej5controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string dia)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dia))
                {
                    return BadRequest("El día no puede estar vacío");
                }

                // Normalizar texto
                dia = dia.Trim().ToLower();

                if (dia == "sabado" || dia == "sábado" || dia == "domingo")
                {
                    return Ok("Es fin de semana");
                }
                else if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "miércoles" || dia == "jueves" || dia == "viernes")
                {
                    return Ok("No es fin de semana");
                }
                else
                {
                    return BadRequest("Día inválido");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}