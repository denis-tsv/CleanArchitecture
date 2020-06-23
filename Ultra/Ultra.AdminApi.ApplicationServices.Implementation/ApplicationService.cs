using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ultra.AdminApi.ApplicationServices.Interfaces;

namespace Ultra.AdminApi.ApplicationServices.Implementation
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
