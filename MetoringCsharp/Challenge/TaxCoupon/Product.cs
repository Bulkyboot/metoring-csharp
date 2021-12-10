using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.TaxCoupon
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public Product(string name, decimal price, decimal discount)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }
    }
}
