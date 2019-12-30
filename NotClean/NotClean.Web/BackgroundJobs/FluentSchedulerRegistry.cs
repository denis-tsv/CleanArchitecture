using FluentScheduler;

namespace NotClean.Web.BackgroundJobs
{
    public class FluentSchedulerRegistry : Registry
    {
        public FluentSchedulerRegistry()
        {
            Schedule<SendEmailsJob>().NonReentrant().ToRunEvery(1).Minutes();
        }
    }
}
