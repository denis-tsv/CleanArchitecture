using FluentScheduler;

namespace Min.Web.BackgroundJobs
{
    public class FluentSchedulerRegistry : Registry
    {
        public FluentSchedulerRegistry()
        {
            Schedule<SendEmailsJob>().NonReentrant().ToRunEvery(1).Minutes();
        }
    }
}
