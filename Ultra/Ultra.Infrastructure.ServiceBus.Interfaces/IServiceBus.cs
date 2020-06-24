using System.Threading.Tasks;

namespace Ultra.Common.Infrastructure.ServiceBus.Interfaces
{
    public interface IServiceBus
    {
        Task SendMessageAsync<TMessage>(TMessage message) where TMessage : Message;
    }
}
