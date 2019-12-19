using System.Collections.Generic;

namespace OnlineShop.Domans
{
    public class Order : Entity
    {
        public virtual ICollection<ProductInOrder> ProductsInOrder { get; set; }
        public bool IsPayed { get; set; }
        public string PaymentUrl { get; set; }
        public string DeliveryAddress { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}