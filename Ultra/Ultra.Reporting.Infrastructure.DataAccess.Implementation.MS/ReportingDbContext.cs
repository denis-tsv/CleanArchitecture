using Microsoft.EntityFrameworkCore;
using Ultra.Reporting.Domain.Entities;
using Ultra.Reporting.Infrastructure.DataAccess.Interfaces;

namespace Ultra.Reporting.Infrastructure.DataAccess.Implementation.MS
{
    public class ReportingDbContext : DbContext, IReportingDbContext
    {
        public DbSet<AggregatedDataItem> AggregatedDataItems { get; set; }
    }
}
