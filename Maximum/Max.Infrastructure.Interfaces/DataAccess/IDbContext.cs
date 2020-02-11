using System.Threading;
using System.Threading.Tasks;
using Max.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Max.Infrastructure.Interfaces.DataAccess
{
    internal interface IDbContext
    {
        DbSet<Order> Orders { get; }

        DbSet<Email> Emails { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges();
    }
}
