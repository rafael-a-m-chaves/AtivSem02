﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_opcional_
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        private static void RepositoryDependence(IServiceCollection serviceProvider)
        {
            //serviceProvider.AddScoped<IProdutoRepository, ProdutoRepository>();
            //serviceProvider.AddScoped<IPedidoRepository, PedidoRepository>();
            //serviceProvider.AddScoped<ICidadeRepository, CidadeRepository>();
        }
    }
}
