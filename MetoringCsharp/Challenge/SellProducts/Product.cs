using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.SellProducts
{
    public class Product
    {
        public string Name { get; set; }
        public double Price{ get; set; }
        public double Amount { get; set; }

        public Product(string name, double price, double amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public Product()
        {
        }
        public double ProductADD(double amount) {
            amount += amount;
            return amount;
        }
        public double ProductRemove(double amount)
        {
            amount -= amount;
            return amount;
        }
        public double SunProduct(double finalValue, double price, double amount)
        {
            return finalValue = price + amount;
        }
    }
}
