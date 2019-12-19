using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domans
{
    public class ProductInOrder : Entity
    {
        public virtual Order Order { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
