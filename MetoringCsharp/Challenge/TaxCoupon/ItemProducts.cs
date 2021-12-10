using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.TaxCoupon
{
    public class ItemProducts
    {
        public Product Product { get; set; }
        public decimal amount;

        public ItemProducts(string nameProduct, decimal price, decimal discount, decimal amount)
        {
            Product = new Product(nameProduct, price, discount);
            this.amount = amount;
        }

        public ItemProducts()
        {

        }

        public decimal TotalPrice(decimal price, decimal discount, decimal amount)
        {
            return (price * amount) - ((price * amount) * (discount/100));
        }

        public ItemProducts AddProduct(string nameProduct, decimal price, decimal discount, decimal amount)
        {
            ItemProducts itemProduct = new ItemProducts(nameProduct, price, discount, amount)
            {
                Product = new Product(nameProduct, price, discount),
                amount = amount
            };

            return itemProduct;
        }
    }
}
