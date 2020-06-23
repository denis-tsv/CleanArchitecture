using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ultra.DownloadService.Controllers
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
