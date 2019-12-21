using FluentScheduler;

namespace Mid.Infrastructure.Implementation.BackgroundJobs
{
    public class FluentSchedulerRegistry : Registry
    {
        public FluentSchedulerRegistry()
        {
            Schedule<SendEmailsJob>().NonReentrant().ToRunEvery(1).Minutes();
        }
    }
}
