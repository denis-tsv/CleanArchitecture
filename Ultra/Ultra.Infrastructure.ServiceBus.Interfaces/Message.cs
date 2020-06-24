using System;

namespace Ultra.Common.Infrastructure.ServiceBus.Interfaces
{
    public abstract class Message
    {
        public Guid CorrelationId { get; set; }
    }
}
