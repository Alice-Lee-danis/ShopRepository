using Microsoft.AspNetCore.Mvc;
using ShopBasket.Purchase;
using ShopBasket.Services;

namespace ShopBasket.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        ProductRepository _service;

        public ProductController(ProductRepository _service)
        {
            this._service = _service;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll(int from, int to)
        {
            return _service.GetAll(from, to);
        }
    }
}
