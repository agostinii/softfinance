using Microsoft.AspNetCore.Mvc;
using SoftFinance.Api.Services;

namespace SoftFinance.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public TaxaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        [HttpGet, Route("taxajuros")]
        public IActionResult Get()
        {
            var response = _taxaJurosService.Get();
            if(!response.Success) {
                return BadRequest(response);
            };
            return Ok(response);
        }
    }
}
