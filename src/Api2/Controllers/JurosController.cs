using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api2/[controller]")]
    [ApiController]
    public class JurosController : Controller
    {
        readonly protected IJuroService _servico;

        public JurosController(IJuroService servico)
        {
            _servico = servico;
        }

        [HttpGet("calculajuros")]
        public async Task<ActionResult<double>> Get(decimal valorInicial, int meses)
        {
            var calculo = await _servico.CalculaJuros(valorInicial, meses);
            if (calculo.Retorno)
                return calculo.Valor;
            else
                return BadRequest(calculo.Mensagem);
        }
    }
}