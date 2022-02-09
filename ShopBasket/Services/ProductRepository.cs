using ShopBasket.Context;
using ShopBasket.DTOs;
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

        public IEnumerable<ProductDTO> GetAllDTO(int from, int to)
        {
            var product = from b in _context.products
                          select new ProductDTO()
                          {
                              Id = b.Id,
                              Name = b.Name, SupplierName = b.Supplier.Name

                          };

            return product.Where(i => i.Id >= from && i.Id <= to);
        }
    }
}
