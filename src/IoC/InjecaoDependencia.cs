using Application.Interfaces;
using Application.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    public class InjecaoDependencia
    {
        public static void Registrar(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IJuroService, JuroService>();
        }
    }
}
