using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ultra.Web.DownloadService.Controllers
{
    public class DownloadController : ControllerBase
    {
        [HttpGet]
        public Task<string> ExternalSystemCallThisMethodToDownloadDataFromOurSystem()
        {
            return Task.FromResult("");
        }
    }
}
