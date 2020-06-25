using System.Threading.Tasks;
using MediatR;
using Ultra.WebJob.UseCases.RegularCommands.RunCommand;

namespace Ultra.WebJob.Hosting
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //web jobs - analog of controllers. they doesn't contain logic, they only start use cases 
            IMediator mediator = null;
            await mediator.Send(new RunRequest());
        }
    }
}
