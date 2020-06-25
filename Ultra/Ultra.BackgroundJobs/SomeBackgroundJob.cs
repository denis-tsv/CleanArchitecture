using System.Threading.Tasks;
using MediatR;
using Ultra.Web.BackgroundJobs.UseCases.JobOperation;

namespace Ultra.Web.BackgroundJobs
{
    public class SomeBackgroundJob
    {
        private readonly IMediator _mediator;

        public SomeBackgroundJob(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task RunAsync()
        {
            //background jobs - analog of controllers. they doesn't contain logic, they only start use cases 
            return _mediator.Send(new JobOperationRequest());
        }
    }
}
