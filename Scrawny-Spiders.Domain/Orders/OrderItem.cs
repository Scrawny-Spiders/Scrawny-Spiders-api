using Scrawny.Spider.Domain.Catalog;

namespace Scrawny.Spider.Domain.Orders
{
    public class OrderItem
    {
        public int Id {get; set;}
        public Item Item {get; set;}
        public int Quanity {get; set;}
        public decimal Price => Item.Price * Quanity;
    }
}