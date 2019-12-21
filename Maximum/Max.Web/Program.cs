using FluentScheduler;
using Max.Infrastructure.Implementation.BackgroundJobs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Max.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            JobManager.JobFactory = new JobFactory(host.Services);
            JobManager.Initialize(new FluentSchedulerRegistry());
            JobManager.JobException += info =>
            {
                var logger = host.Services.GetRequiredService<ILogger<Program>>();
                logger.LogError(info.Exception, "Unhandled exception in job");
            };

            //AssemblyStatisticCalculator.Calculate();
            
            host.Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
