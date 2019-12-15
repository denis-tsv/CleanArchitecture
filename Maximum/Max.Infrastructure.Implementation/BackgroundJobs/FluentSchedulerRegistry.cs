using FluentScheduler;

namespace Max.Infrastructure.Implementation.BackgroundJobs
{
    internal class FluentSchedulerRegistry : Registry
    {
        public FluentSchedulerRegistry()
        {
            Schedule<SendEmailsJob>().NonReentrant().ToRunEvery(1).Minutes();
        }
    }
}
