using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ultra.Common.Domain.Entities.Models;

namespace Ultra.Common.Infrastructure.DataAccess.Interfaces
{
    public interface ICommonDbContext
    {
        DbSet<Order> Orders { get; }
        DbSet<OrderItem> OrderItems { get; }
        DbSet<Product> Products { get; }
        DbSet<Email> Emails { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
