using System.Threading.Tasks;

namespace Ultra.Integrations.Emailing.Interfaces
{
    public interface IEmailingService
    {
        Task SendEmailAsync(string from, string to, string subject, string body);
    }
}