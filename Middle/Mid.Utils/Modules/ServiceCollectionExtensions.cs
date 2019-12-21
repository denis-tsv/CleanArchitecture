using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mid.Utils.Modules
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterModule<T>(this IServiceCollection serviceCollection, IConfiguration configuration)
            where T : Module
        {
            var module = Activator.CreateInstance<T>();

            module.Configuration = configuration;

            module.Load(serviceCollection);
        }
    }
}
