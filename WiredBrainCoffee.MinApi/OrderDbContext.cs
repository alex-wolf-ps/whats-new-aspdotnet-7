using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.MinApi
{

    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Order> Orders => Set<Order>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    Notes = "A coffee order",
                    PromoCode = "Wired123",
                    Created = DateTime.Now,
                    OrderNumber = 100
                },
                new Order
                {
                    Id = 2,
                    Notes = "A food order",
                    PromoCode = "Wired123",
                    Created = DateTime.Now,
                    OrderNumber = 125,
                }
            );
            
        }
    }
}
