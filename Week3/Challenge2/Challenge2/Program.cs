using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.Class;

namespace Challenge2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            product.MainScreen();
            int option = product.option();
            List <Product> list = new List<Product>();

            while(option<=5)
            {
                //Get the data of the product
                if (option == 1)
                {
                    product.AddProduct();
                    list.Add(product);
                }
                //View the products on the screen
                else if (option == 2)
                {
                    product.ViewProduct(list);
                }
                else if(option == 3)
                {
                    var NewList = list.Max(o => o.price);
                    Console.WriteLine("Highest Unit Price: " + NewList);
                }
                option = product.option();
            }
            Console.ReadKey();
        }
    }
}
