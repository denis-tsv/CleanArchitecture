using Microsoft.EntityFrameworkCore;
using Ultra.Entities.Models;
using Ultra.Infrastructure.DataAccess.Interfaces;

namespace Ultra.Infrastructure.DataAccess.Implementation.MsSql
{
    internal class AppDbContext : DbContext, IDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Email> Emails { get; set; }
        
    }
}
