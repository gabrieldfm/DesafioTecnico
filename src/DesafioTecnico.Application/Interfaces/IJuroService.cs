using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IJuroService
    {
        Task<CalculaJurosDto> CalculaJuros(decimal valorInicial, int meses);
    }
}
