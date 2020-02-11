using Microsoft.EntityFrameworkCore;
using Mid.Entities.Models;

namespace Mid.DataAccess.MsSql
{
    internal static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = 10
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 20
                },
                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Price = 100
                }
            );
        }
    }
}
