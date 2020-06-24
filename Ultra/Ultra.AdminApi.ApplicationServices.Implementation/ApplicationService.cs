using System;
using System.Threading.Tasks;
using Ultra.Web.AdminApi.ApplicationServices.Interfaces;

namespace Ultra.Web.AdminApi.ApplicationServices.Implementation
{
    public class ApplicationService : IApplicationService
    {
        public Task ExecuteStoredProcedure()
        {
            throw new NotImplementedException();
        }

        public Task<ReportModel> ExecuteRawSqlScript()
        {
            throw new NotImplementedException();
        }
    }
}
