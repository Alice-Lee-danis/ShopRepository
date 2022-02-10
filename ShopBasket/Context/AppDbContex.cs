using Microsoft.EntityFrameworkCore;
using ShopBasket.Purchase;

namespace ShopBasket.Context
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options)
            : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Basket> Baskets { get; set; }

    }
}
