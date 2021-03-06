using ShopBasket.Context;
using ShopBasket.DTOs;
using ShopBasket.Purchase;

namespace ShopBasket.Services
{
    public class BasketRepository
    {
        private readonly AppDbContex _context;

        public BasketRepository(AppDbContex _context)
        {
            this._context = _context;
        }

        public Basket Create(Basket basket)
        {
            _context.Baskets!.Add(basket);
            _context.SaveChanges();
            return basket;
        }

        public void DeleteById(int id)
        {
            var BasketDel = _context.Baskets!.Find(id);
            if (BasketDel is not null)
            {
                _context.Baskets!.Remove(BasketDel);
                _context.SaveChanges();
            }
        }

        public BasketDTO GetByIdDTO(int id)
        {
            var basket = _context.Baskets.Select(x => new BasketDTO{ Id = x.Id }).SingleOrDefault(p => p.Id == id);
            return basket;
        }
    }
}
