using ShopBasket.Context;
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
            _context.baskets!.Add(basket);
            _context.SaveChanges();

            return basket;
        }

        public Basket? GetById(int id)
        {
            return _context.baskets!


                .SingleOrDefault(p => p.Id == id);
        }


        public void DeleteById(int id)
        {
            var BasketDel = _context.baskets!.Find(id);
            if (BasketDel is not null)
            {
                _context.baskets!.Remove(BasketDel);
                _context.SaveChanges();
            }
        }
    }
}
