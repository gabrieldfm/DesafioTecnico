using Api2.Tests.Helpers;
using Application.Dtos;
using Application.Interfaces;
using Application.Servicos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api2.Tests
{
    [TestFixture]
    public class CalculoJuros
    {
        private JuroService _servico;

        [SetUp]
        public void SetUp()
        {
            _servico = new JuroService();
        }

        [TestCase(0, 5)]
        [TestCase(100, 0)]
        public void ValidaValoresValorInicialETempoZeradoDeveRetornarFalso(decimal arg1, int arg2)
        {
            RetornoAcessoExternoDto arg3 = new RetornoAcessoExternoDto { Retorno = true, Valor = 1, Mensagem = "OK" };

            var retono = (CalculaJurosDto)Helper.InvokePrivateMethod<JuroService>(_servico, "ValidaValores", new object[] { arg1, arg2, arg3});
            Assert.AreEqual(false, retono.Retorno);
        }

        [TestCase(100, 5)]
        [TestCase(100, 7)]
        public void ValidaValoresTaxaJurosZeradoDeveRetornarFalso(decimal arg1, int arg2)
        {
            RetornoAcessoExternoDto arg3 = new RetornoAcessoExternoDto { Retorno = false, Valor = 0, Mensagem = "Falha ao recuperar taxa de juros" };

            var retono = (CalculaJurosDto)Helper.InvokePrivateMethod<JuroService>(_servico, "ValidaValores", new object[] { arg1, arg2, arg3 });
            Assert.AreEqual(false, retono.Retorno);
        }

        [TestCase(100, 5)]
        [TestCase(100, 7)]
        public void ValidaValoresOkDeveRetornarVerdadeiro(decimal arg1, int arg2)
        {
            RetornoAcessoExternoDto arg3 = new RetornoAcessoExternoDto { Retorno = true, Valor = 1, Mensagem = "OK" };

            var retono = (CalculaJurosDto)Helper.InvokePrivateMethod<JuroService>(_servico, "ValidaValores", new object[] { arg1, arg2, arg3 });
            Assert.AreEqual(true, retono.Retorno);
        }
    }
}
