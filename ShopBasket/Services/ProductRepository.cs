using ShopBasket.Context;
using ShopBasket.Purchase;

namespace ShopBasket.Services
{
    public class ProductRepository
    {

        private readonly AppDbContex _context;

        public ProductRepository(AppDbContex _context)
        {
            this._context = _context;
        }

        public IEnumerable<Product> GetAll(int from, int to)
        {
            return _context.products!.Where(i => i.Id >= from && i.Id <= to);
        }


    }
}
