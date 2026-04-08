using Microsoft.AspNetCore.Mvc;

namespace Ej6controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(decimal precio, int cantidad, string formaPago, string? numeroTarjeta)
        {
            try
            {
                if (precio <= 0 || cantidad <= 0)
                {
                    return BadRequest("Precio y cantidad deben ser positivos");
                }

                formaPago = formaPago.Trim().ToLower();

                decimal total = precio * cantidad;

                if (formaPago == "tarjeta")
                {
                    if (string.IsNullOrWhiteSpace(numeroTarjeta) || numeroTarjeta.Length != 16 || !numeroTarjeta.All(char.IsDigit))
                    {
                        return BadRequest("Número de tarjeta inválido (debe tener 16 dígitos)");
                    }

                    total = total * 1.10m; // 10% recargo
                    return Ok($"Total con recargo: {total}");
                }
                else if (formaPago == "efectivo")
                {
                    return Ok($"Total a pagar: {total}");
                }
                else
                {
                    return BadRequest("Forma de pago inválida");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}