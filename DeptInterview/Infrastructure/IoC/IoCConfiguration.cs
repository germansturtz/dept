using Infrastructure.Repositories;

using Logic.Contracts;
using Logic.Implementations;
using Logic.Interfaces.Repositories;

using Microsoft.Extensions.DependencyInjection;

using Nest;

using System;

namespace Infrastructure.IoC
{
    public class IoCConfiguration
    {
        private const string URL = "http://localhost:9200";

        public static void Configure(IServiceCollection services)
        {
            var settings = new ConnectionSettings(new Uri(URL));
            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);

            services.AddTransient<ICommunitieLogic, CommunitieLogic>();
            services.AddTransient<ICommunitiesRepository, CommunitiesRepository>();
        }
    }
}


