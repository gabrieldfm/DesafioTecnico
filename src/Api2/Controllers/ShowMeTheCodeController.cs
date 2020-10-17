using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api2/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : Controller
    {
        public ActionResult<string> Get()
        {
            return "https://github.com/gabrieldfm/DesafioTecnico";
        }
    }
}