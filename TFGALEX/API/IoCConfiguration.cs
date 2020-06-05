﻿using Domain;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class IoCConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            RegisterRepositories(services);
            RegisterServices(services);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IDispatchService, DispatchService>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IArrivalService, ArrivalService>();
            services.AddTransient<ISerialService, SerialService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            //services.AddTransient<IClientRepository, ClientRepository>();
        }
    }
}