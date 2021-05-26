using DesafioTecnico.Api1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.Api1.Controllers
{
    [ApiController]
    [Route("api1/[controller]")]
    public class TaxaJurosController : Controller
    {
        private readonly IJuros _juros;

        public TaxaJurosController(IJuros juros)
        {
            _juros = juros;
        }

        [HttpGet]
        public ActionResult<double> Get()
        {
            return _juros.Taxa;
        }
    }
}
