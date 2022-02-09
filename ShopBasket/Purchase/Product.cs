using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ShopBasket.Purchase
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public Supplier Supplier { get; set; }

        [JsonIgnore]
        public ICollection<Basket>? Basket { get; set; }

    }
}
