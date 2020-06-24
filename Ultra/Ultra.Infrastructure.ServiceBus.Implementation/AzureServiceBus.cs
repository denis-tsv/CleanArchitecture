using System;
using System.Threading.Tasks;
using Ultra.Common.Infrastructure.ServiceBus.Interfaces;

namespace Ultra.Common.Infrastructure.ServiceBus.Implementation.Azure
{
    public class AzureServiceBus : IServiceBus
    {
        public Task SendMessageAsync<TMessage>(TMessage message) where TMessage : Message
        {
            throw new NotImplementedException();
        }
    }
}
