using Application.Interfaces;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Servicos
{
    public class JuroService : IJuroService
    {
        protected readonly Juro servico;

        public JuroService()
        {
            this.servico = new Juro();
        }

        public double GetTaxaJuros()
        {
            return servico.GetTaxaJuros();
        }
    }
}
