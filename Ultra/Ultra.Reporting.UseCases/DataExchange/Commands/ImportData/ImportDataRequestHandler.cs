using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Ultra.Common.Infrastructure.DataAccess.Interfaces;
using Ultra.Reporting.Infrastructure.DataAccess.Interfaces;

namespace Ultra.Reporting.UseCases.DataExchange.Commands.ImportData
{
    public class ImportDataRequestHandler : AsyncRequestHandler<ImportDataRequest>
    {
        private readonly IReportingDbContext _reportingDbContext;
        private readonly ICommonDbContext _commonDbContext;

        public ImportDataRequestHandler(IReportingDbContext reportingDbContext, ICommonDbContext commonDbContext)
        {
            _reportingDbContext = reportingDbContext;
            _commonDbContext = commonDbContext;
        }
        protected async override Task Handle(ImportDataRequest request, CancellationToken cancellationToken)
        {
            //Load data from common context and save to reporting context
        }
    }
}
