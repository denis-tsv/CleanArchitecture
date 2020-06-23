using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ultra.Infrastructure.ServiceBus.Interfaces;

namespace Ultra.Infrastructure.ServiceBus.Implementation
{
    public class AzureServiceBus : IServiceBus
    {
        public Task SendMessageAsync<TMessage>(TMessage message) where TMessage : Message
        {
            throw new NotImplementedException();
        }
    }
}
