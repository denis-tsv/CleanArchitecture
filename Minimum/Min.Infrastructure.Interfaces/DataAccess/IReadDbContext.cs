using System.Linq;
using Min.Entities;
using Min.Entities.Models;

namespace Min.Infrastructure.Interfaces.DataAccess
{
    public interface IReadDbContext
    {
        IQueryable<Order> Orders { get; }

        IQueryable<Email> Emails { get; }
    }
}
