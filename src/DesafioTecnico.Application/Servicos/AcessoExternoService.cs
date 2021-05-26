using Application.Dtos;
using Application.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Application.Servicos
{
    public class AcessoExternoService : IAcessoExternoService
    {
        private readonly string jurosEndPoint = "https://localhost:44321/api1/taxajuros";

        public async Task<RetornoAcessoExternoDto> ConsultarTaxaJuros()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(jurosEndPoint);
                if (response.IsSuccessStatusCode)
                {
                    var valor = Convert.ToDouble(await response.Content.ReadAsStringAsync(), System.Globalization.CultureInfo.InvariantCulture);
                    return new RetornoAcessoExternoDto
                    {
                        Retorno = true,
                        Valor = valor,
                        Mensagem = "OK"
                    };
                }
                else
                    return new RetornoAcessoExternoDto
                    {
                        Retorno = false,
                        Valor = 0,
                        Mensagem = "Falha ao recuperar taxa de juros"
                    };
            }
        }
    }
}
