using System.Linq;
using Min.Infrastructure.Interfaces.DataAccess;
using Microsoft.EntityFrameworkCore;
using Min.Entities;
using Min.Entities.Models;

namespace Min.DataAccess.MsSql
{
    public class AppDbContext : DbContext, IDbContext, IReadDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Email> Emails { get; set; }

        IQueryable<Email> IReadDbContext.Emails => Emails.AsNoTracking();
        IQueryable<Order> IReadDbContext.Orders => Orders.AsNoTracking();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
