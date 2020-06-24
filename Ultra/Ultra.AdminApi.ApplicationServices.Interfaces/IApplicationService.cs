using System.Threading.Tasks;

namespace Ultra.Web.AdminApi.ApplicationServices.Interfaces
{
    //Used in many Admin handlers
    public interface IApplicationService
    {
        Task ExecuteStoredProcedure();
        Task<ReportModel> ExecuteRawSqlScript();
    }
}
