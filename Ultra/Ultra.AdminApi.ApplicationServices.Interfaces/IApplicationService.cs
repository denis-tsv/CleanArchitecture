using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ultra.AdminApi.ApplicationServices.Interfaces
{
    //Used in many Admin handlers
    public interface IApplicationService
    {
        Task ExecuteStoredProcedure();
        Task<ReportModel> ExecuteRawSqlScript();
    }
}
