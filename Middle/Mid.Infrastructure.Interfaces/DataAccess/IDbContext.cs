using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mid.Entities.Models;

namespace Mid.Infrastructure.Interfaces.DataAccess
{
    internal interface IDbContext
    {
        DbSet<Order> Orders { get; }

        DbSet<Email> Emails { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges();
    }
}
