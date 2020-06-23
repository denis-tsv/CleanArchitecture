using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ultra.Infrastructure.ServiceBus.Interfaces
{
    public interface IServiceBus
    {
        Task SendMessageAsync<TMessage>(TMessage message) where TMessage : Message;
    }
}
