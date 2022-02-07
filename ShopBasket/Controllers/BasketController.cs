using Microsoft.AspNetCore.Mvc;
using ShopBasket.Purchase;
using ShopBasket.Services;

namespace ShopBasket.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        BasketRepository _service;

        public BasketController(BasketRepository _service)
        {
            this._service = _service;
        }


        [HttpGet("{id}")]
        public ActionResult<Basket> GetById(int id)
        {
            var basket = _service.GetById(id);

            if (basket is not null)
            {
                return basket;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Create(Basket newBasket)
        {
            var basket = _service.Create(newBasket);
            return CreatedAtAction(nameof(GetById), new { id = basket!.Id }, basket);
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var basket = _service.GetById(id);

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
    }
}
