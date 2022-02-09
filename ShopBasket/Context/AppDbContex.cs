using Microsoft.EntityFrameworkCore;
using ShopBasket.Purchase;

namespace ShopBasket.Context
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options)
            : base(options)
        { }
        public DbSet<Product> products { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Basket> baskets { get; set; }

    }
}
