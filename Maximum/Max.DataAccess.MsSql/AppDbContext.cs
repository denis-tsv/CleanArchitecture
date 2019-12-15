using Max.Entities;
using Max.Infrastructure.Interfaces.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Max.DataAccess.MsSql
{
    internal class AppDbContext : DbContext, IDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Email> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
