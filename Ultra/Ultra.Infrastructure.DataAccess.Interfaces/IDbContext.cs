using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ultra.Entities.Models;

namespace Ultra.Infrastructure.DataAccess.Interfaces
{
    public interface IDbContext
    {
        DbSet<Order> Orders { get; }
        DbSet<OrderItem> OrderItems { get; }
        DbSet<Product> Products { get; }
        DbSet<Email> Emails { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
