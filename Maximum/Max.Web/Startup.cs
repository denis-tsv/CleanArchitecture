using AutoMapper;
using Max.Controllers;
using Max.DataAccess.MsSql;
using Max.DomainServices.Implementation;
using Max.DomainServices.Interfaces;
using Max.Infrastructure.Implementation.BackgroundJobs;
using Max.Infrastructure.Implementation.Services;
using Max.Infrastructure.Interfaces.DataAccess;
using Max.Infrastructure.Interfaces.Options;
using Max.Infrastructure.Interfaces.Services;
using Max.UseCases.Handlers.Orders.Commands.CreateOrder;
using Max.UseCases.Handlers.Orders.Mappings;
using Max.Web.Utils;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Max.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(OrdersAutoMapperProfile));
            services.AddMediatR(typeof(CreateOrderRequest));

            services.AddOptions();
            services.Configure<EmailOptions>(Configuration.GetSection("EmailOptions"));

            services.AddDbContext<IDbContext, AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection")));

            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IEmailService, EmailService>();

            services.AddTransient<SendEmailsJob>();

            services.AddHttpContextAccessor();

            services.AddControllers()
                .AddApplicationPart(typeof(OrdersController).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseExceptionHandlerMiddleware();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
