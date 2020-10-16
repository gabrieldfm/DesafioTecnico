using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [Route("api1/[controller]")]
    [ApiController]
    public class JurosController : Controller
    {
        readonly protected IJuroService servico;

        public JurosController(IJuroService servico)
        {
            this.servico = servico;
        }

        [HttpGet("taxaJuros")]
        public ActionResult<double> Get()
        {
            return servico.GetTaxaJuros();
        }
    }
}