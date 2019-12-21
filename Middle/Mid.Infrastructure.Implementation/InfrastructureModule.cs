using Microsoft.Extensions.DependencyInjection;
using Mid.Infrastructure.Implementation.BackgroundJobs;
using Mid.Infrastructure.Implementation.Services;
using Mid.Infrastructure.Interfaces.Options;
using Mid.Infrastructure.Interfaces.Services;
using Mid.Utils.Modules;

namespace Mid.Infrastructure.Implementation
{
    public class InfrastructureModule : Module
    {
        public override void Load(IServiceCollection services)
        {
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IEmailService, EmailService>();

            services.AddTransient<SendEmailsJob>();

            services.Configure<EmailOptions>(Configuration.GetSection("EmailOptions"));
        }
    }
}
