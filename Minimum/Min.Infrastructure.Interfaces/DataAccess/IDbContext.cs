using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Min.Entities;
using Min.Entities.Models;

namespace Min.Infrastructure.Interfaces.DataAccess
{
    public interface IDbContext
    {
        DbSet<Order> Orders { get; }

        DbSet<Email> Emails { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges();
    }
}
