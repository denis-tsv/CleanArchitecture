using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Ultra.WebJob.UseCases.RegularCommands.RunCommand;

namespace Ultra.WebJob.UseCases.RegularCommands.Run
{
    public class RunRequestHandler : AsyncRequestHandler<RunRequest>
    {
        protected override Task Handle(RunRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
