using System;
using System.Collections.Generic;
using System.Text;

namespace Ultra.Infrastructure.WebHost.Interfaces
{
    public interface IUrlGenerator
    {
        string GetRestorePasswordUrl();
    }
}
