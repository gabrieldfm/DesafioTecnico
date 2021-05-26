using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.Api2.Controllers
{
    [Route("api2/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "https://github.com/gabrieldfm/DesafioTecnico";
        }
    }
}
