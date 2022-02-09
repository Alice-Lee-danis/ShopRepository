using Microsoft.AspNetCore.Mvc;
using ShopBasket.Context;
using ShopBasket.DTOs;
using ShopBasket.Purchase;
using ShopBasket.Services;

namespace ShopBasket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _service;

        public ProductController(ProductRepository _service)
        {
            this._service = _service;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetAllDTO(int from, int to)
        {
            return _service.GetAllDTO(from, to);
        }
    }
}


