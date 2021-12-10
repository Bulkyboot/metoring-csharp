using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace MetoringCsharp.Challenge.SellProducts
{
    public class ProductListInfoExecute
    {
        public static void Execute()
        {
            double price = 900;
            double amount = 5;

            Product product = new Product();
            product.Price = price;
            product.Amount = amount;

            Console.WriteLine("Price = ", price, " amount = ", amount, " Total = ", product.SunProduct);

            Console.WriteLine("Enter the information in what operetion you what to do");
            Console.WriteLine("ADD product = 1\n\nRemove Poduct = 2\n\nEnd the Program = 3");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    product.ProductADD(amount = 5);
                    Console.WriteLine("Price = ", price, " amount = ", amount, " Total = ", product.SunProduct);

                    break;
                case 2:
                    product.ProductRemove(amount = 3);
                    Console.WriteLine("Price = ", price, " amount = ", amount, " Total = ", product.SunProduct);
                    break;
                case 3:
                    //finaliza o programa
                    break;
                default:
                    Console.WriteLine("Don't exist");
                    break;
            }
        }
    }
}