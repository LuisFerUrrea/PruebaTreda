using Microsoft.Extensions.DependencyInjection;
using Prueba.Trade.Application.Contracts.Services;
using Prueba.Trade.Application.Services;
using Prueba.Trade.DataAccess.Contracts.Repositories;
using Prueba.Trade.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Trade.CrossCutting
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);
            return services;
        }

        public static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            services.AddTransient<IProductoService, ProductoService>();
            return services;
        }


        public static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IProductoRepository, ProductoRepository>();
            return services;
        }
    }
}
