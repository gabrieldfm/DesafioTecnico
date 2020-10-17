using Application.Dtos;
using Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Application.Servicos
{
    public class JuroService : IJuroService
    {
        private readonly IAcessoExternoService _acessoExternoService;

        public JuroService(IAcessoExternoService acessoExternoService)
        {
            _acessoExternoService = acessoExternoService;
        }

        public JuroService() { }

        public async Task<CalculaJurosDto> CalculaJuros(decimal valorInicial, int meses)
        {
            var retornoConsulta = await _acessoExternoService.ConsultarTaxaJuros();
            var validacao = ValidaValores(valorInicial, meses, retornoConsulta);
            if (validacao.Retorno)
                validacao.Valor = TruncarValor(CalculaValor(valorInicial, meses, retornoConsulta.Valor));

            return validacao;
        }

        private CalculaJurosDto ValidaValores(decimal valorInicial, int meses, RetornoAcessoExternoDto retornoConsulta)
        {
            if (!retornoConsulta.Retorno)
                return new CalculaJurosDto { Retorno = false, Valor = 0, Mensagem = retornoConsulta.Mensagem };
            else if (valorInicial == 0)
                return new CalculaJurosDto { Retorno = false, Valor = 0, Mensagem = "Valor inicial zerado" };
            else if(meses == 0)
                return new CalculaJurosDto { Retorno = false, Valor = 0, Mensagem = "Valor tempo zerado" };

            return new CalculaJurosDto { Retorno = true, Valor = 0, Mensagem = "OK" };
        }

        private double CalculaValor(decimal valorInicial, int meses, double juros)
        {
            var taxa = Math.Pow(Convert.ToDouble(1 + (juros / 100)), meses);
            return (double)valorInicial * taxa;
        }

        private double TruncarValor(double valorBruto)
        {
            return Math.Round(valorBruto, 2);
        }
    }
}
