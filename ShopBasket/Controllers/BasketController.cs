using Microsoft.AspNetCore.Mvc;
using ShopBasket.DTOs;
using ShopBasket.Purchase;
using ShopBasket.Services;

namespace ShopBasket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly BasketRepository _service;

        public BasketController(BasketRepository _service)
        {
            this._service = _service;
        }

        [HttpPost]
        public IActionResult Create(Basket newBasket)
        {
            var basket = _service.Create(newBasket);
            return CreatedAtAction(nameof(GetByIdDTO), new { id = basket!.Id }, basket);  
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var basket = _service.GetByIdDTO(id);

            if (basket is not null)
            {
                _service.DeleteById(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public ActionResult<BasketDTO> GetByIdDTO(int id)
        {
            var basket = _service.GetByIdDTO(id);

            if (basket is not null)
            {
                return basket;
            }
            else
            {
                return NotFound();
            }
        }
    }
}
