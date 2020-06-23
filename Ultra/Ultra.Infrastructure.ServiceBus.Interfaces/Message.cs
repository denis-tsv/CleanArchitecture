using System;
using System.Collections.Generic;
using System.Text;

namespace Ultra.Infrastructure.ServiceBus.Interfaces
{
    public abstract class Message
    {
        public Guid CorrelationId { get; set; }
    }
}
