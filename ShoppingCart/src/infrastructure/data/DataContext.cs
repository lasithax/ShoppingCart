using Bookshop_be.src.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookshop_be.src.infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
