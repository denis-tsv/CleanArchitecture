using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Min.DataAccess.MsSql;
using Min.Infrastructure.Interfaces.DataAccess;
using Min.Infrastructure.Interfaces.Options;
using Min.Infrastructure.Interfaces.Services;
using Min.UseCases.Handlers.Orders.Commands.CreateOrder;
using Min.UseCases.Handlers.Orders.Mappings;
using Min.Web.BackgroundJobs;
using Min.Web.Services;
using Min.Web.Utils;

namespace Min.Web
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

            services.AddScoped<IDbContext>(factory => factory.GetRequiredService<AppDbContext>());
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection")));

            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IEmailService, EmailService>();

            services.AddTransient<SendEmailsJob>();

            services.AddHttpContextAccessor();

            services.AddControllers();
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

