using System;
using System.Threading.Tasks;
using Ultra.Common.Integrations.Emailing.Interfaces;

namespace Ultra.Common.Integrations.Emailing.Implementation
{
    public class EmailingService : IEmailingService
    {
        public Task SendEmailAsync(string @from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
