namespace ShopBasket.Purchase
{
    public class Basket
    {


        public int Id { get; set; }

        public ICollection<Product> Product { get; set; }



    }
}
