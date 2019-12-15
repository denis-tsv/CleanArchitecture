using System;
using FluentScheduler;
using Microsoft.Extensions.DependencyInjection;

namespace Max.Infrastructure.Implementation.BackgroundJobs
{
    internal class JobFactory : IJobFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public JobFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IJob GetJobInstance<T>() where T : IJob
        {
            var scope = _serviceProvider.CreateScope();
            var res = scope.ServiceProvider.GetService<T>();
            return res;
        }
    }
}
