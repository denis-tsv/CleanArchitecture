using System.Threading.Tasks;

namespace Max.Infrastructure.Interfaces.Services
{
    internal interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string body);
    }
}
