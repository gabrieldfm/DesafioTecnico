using Api1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [Route("api1/[controller]")]
    [ApiController]
    public class TaxaJurosController : Controller
    {
        private readonly IJuros _juros;

        public TaxaJurosController(IJuros juros)
        {
            _juros = juros;
        }

        public ActionResult<double> Get()
        {
            return _juros.Taxa;
        }
    }
}