using System.Threading.Tasks;
using NotClean.DataAccess;
using NotClean.Entities;
using NotClean.Services.Interfaces;

namespace NotClean.Services.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly AppDbContext _dbContext;

        public EmailService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SendEmailAsync(string email, string subject, string body)
        {
            var newMail = new Email
            {
                Address = email,
                Subject = subject,
                Body = body
            };

            _dbContext.Emails.Add(newMail);

            await _dbContext.SaveChangesAsync();
        }
    }
}
