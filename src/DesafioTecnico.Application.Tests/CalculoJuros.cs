using Application.Dtos;
using Application.Servicos;
using DesafioTecnico.Application.Tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesafioTecnico.Application.Tests
{
    public class CalculoJuros
    {
        private JuroService _servico;
        public CalculoJuros()
        {
            _servico = new JuroService();
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(100, 0)]
        public void ValidaValoresValorInicialETempoZeradoDeveRetornarFalso(decimal arg1, int arg2)
        {
            RetornoAcessoExternoDto arg3 = new RetornoAcessoExternoDto { Retorno = true, Valor = 1, Mensagem = "OK" };

            var retono = (CalculaJurosDto)Helper.InvokePrivateMethod<JuroService>(_servico, "ValidaValores", new object[] { arg1, arg2, arg3 });
            Assert.False(retono.Retorno);
        }

        [Theory]
        [InlineData(100, 5)]
        [InlineData(100, 7)]
        public void ValidaValoresTaxaJurosZeradoDeveRetornarFalso(decimal arg1, int arg2)
        {
            RetornoAcessoExternoDto arg3 = new RetornoAcessoExternoDto { Retorno = false, Valor = 0, Mensagem = "Falha ao recuperar taxa de juros" };

            var retono = (CalculaJurosDto)Helper.InvokePrivateMethod<JuroService>(_servico, "ValidaValores", new object[] { arg1, arg2, arg3 });
            Assert.False(retono.Retorno);
        }

        [Theory]
        [InlineData(100, 5)]
        [InlineData(100, 7)]
        public void ValidaValoresOkDeveRetornarVerdadeiro(decimal arg1, int arg2)
        {
            RetornoAcessoExternoDto arg3 = new RetornoAcessoExternoDto { Retorno = true, Valor = 1, Mensagem = "OK" };

            var retono = (CalculaJurosDto)Helper.InvokePrivateMethod<JuroService>(_servico, "ValidaValores", new object[] { arg1, arg2, arg3 });
            Assert.True(retono.Retorno);
        }
    }
}
