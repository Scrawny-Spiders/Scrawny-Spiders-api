using Scrawny.Spider.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Scrawny.Spider.Data {
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }
    }
}

