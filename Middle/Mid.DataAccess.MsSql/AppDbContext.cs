using Microsoft.EntityFrameworkCore;
using Mid.Entities.Models;
using Mid.Infrastructure.Interfaces.DataAccess;

namespace Mid.DataAccess.MsSql
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
