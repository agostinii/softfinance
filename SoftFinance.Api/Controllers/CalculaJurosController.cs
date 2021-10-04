using Microsoft.AspNetCore.Mvc;
using SoftFinance.Api.Services;

namespace SoftFinance.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosController(ICalculaJurosService calculaJurosService)
        {
            _calculaJurosService = calculaJurosService;
        }

        [HttpGet, Route("calculajuros")]
        public IActionResult CalculaJuros(decimal valorInicial, int tempo)
        {
            var response = _calculaJurosService.CalcularJuros(valorInicial, tempo);
            if(!response.Success) {
                return BadRequest(response);
            };
            return Ok(response);
        }

        [HttpGet, Route("showmethecode")]
        public string ShowMeTheCode()
        {
            return "https://github.com/agostinii/softfinance.git";
        }
    }
}
