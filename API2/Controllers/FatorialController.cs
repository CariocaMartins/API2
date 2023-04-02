using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FatorialController : ControllerBase
    {
        [HttpGet("{numero}")]
        public IActionResult Get(int numero)
        {
            if (numero < 0)
            {
                return BadRequest("O número não pode ser negativo");
            }

            int resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return Ok(resultado);
        }
    }
}
