using Scrawny.Spider.Domain.Catalog;
using Scrawny.Spider.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Scrawny.Spider.Data {
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}

