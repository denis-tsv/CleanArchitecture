using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ultra.Integrations.Emailing.Interfaces;

namespace Ultra.Integrations.Emailing.Implementation
{
    public class EmailingService : IEmailingService
    {
        public Task SendEmailAsync(string @from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
