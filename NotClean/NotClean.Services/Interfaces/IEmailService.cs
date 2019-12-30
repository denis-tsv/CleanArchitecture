using System.Threading.Tasks;

namespace NotClean.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string body);
    }
}
