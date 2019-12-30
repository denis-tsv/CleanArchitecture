using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using FluentScheduler;
using Microsoft.Extensions.Options;
using NotClean.DataAccess;
using NotClean.Services.Options;

namespace NotClean.Web.BackgroundJobs
{
    public class SendEmailsJob : IJob
    {
        private readonly AppDbContext _dbContext;
        private readonly EmailOptions _emailOptions;

        public SendEmailsJob(AppDbContext dbContext, IOptions<EmailOptions> emailOptions)
        {
            _dbContext = dbContext;
            _emailOptions = emailOptions.Value;
        }

        public void Execute()
        {
            var client = new SmtpClient(_emailOptions.Server, _emailOptions.Port);
            client.Credentials = new NetworkCredential(_emailOptions.Email, _emailOptions.Password);
            client.EnableSsl = true;

            foreach (var email in _dbContext.Emails.Where(x => !x.IsSended && x.Attempts < 3))
            {
                try
                {
                    var from = new MailAddress(_emailOptions.Email, _emailOptions.FromName);
                    var to = new MailAddress(email.Address);
                    var message = new MailMessage(from, to);
                    message.Subject = email.Subject;
                    message.Body = message.Body;
                    
                    client.Send(message);

                    email.IsSended = true;
                }
                catch (Exception ex)
                {
                    //TODO logging

                    email.Attempts++;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
