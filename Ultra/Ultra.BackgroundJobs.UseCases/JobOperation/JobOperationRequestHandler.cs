using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Ultra.Web.BackgroundJobs.UseCases.JobOperation
{
    public class JobOperationRequestHandler : AsyncRequestHandler<JobOperationRequest>
    {
        protected override Task Handle(JobOperationRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
