using System.Threading.Tasks;

namespace Ultra.Common.Integrations.Emailing.Interfaces
{
    public interface IEmailingService
    {
        Task SendEmailAsync(string from, string to, string subject, string body);
    }
}