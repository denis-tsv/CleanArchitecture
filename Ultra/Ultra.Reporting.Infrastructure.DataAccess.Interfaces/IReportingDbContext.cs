using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Ultra.Reporting.Domain.Entities;

namespace Ultra.Reporting.Infrastructure.DataAccess.Interfaces
{
    public interface IReportingDbContext
    {
        DbSet<AggregatedDataItem> AggregatedDataItems { get; }
    }
}
