using Scrawny.Spider.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Scrawny_Spiders.Data {
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }
    }
}

