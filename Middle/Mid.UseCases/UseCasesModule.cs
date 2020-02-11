using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Mid.UseCases.Handlers.Orders.Commands.CreateOrder;
using Mid.Utils.Modules;

namespace Mid.UseCases
{
    public class UseCasesModule : Module
    {
        public override void Load(IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateOrderRequestHandler));
        }
    }
}
