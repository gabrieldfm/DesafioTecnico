using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class CalculaJurosDto
    {
        public bool Retorno { get; set; }
        public double Valor { get; set; }
        public string Mensagem { get; set; }
    }
}
