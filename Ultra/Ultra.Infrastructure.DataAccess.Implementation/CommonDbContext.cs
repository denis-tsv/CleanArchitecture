using Microsoft.EntityFrameworkCore;
using Ultra.Common.Domain.Entities.Models;
using Ultra.Common.Infrastructure.DataAccess.Interfaces;

namespace Ultra.Common.Infrastructure.DataAccess.Implementation.MsSql
{
    internal class CommonDbContext : DbContext, ICommonDbContext
    {
        public CommonDbContext(DbContextOptions<CommonDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Email> Emails { get; set; }
        
    }
}
