using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("SmartPhone", 100000);
            Product product2 = new Product("Laptop", 200000);
            Product product3 = new Product("Clock", 10000);

            //display
            Console.WriteLine("Product Details:");
            Console.ReadLine();
            Console.WriteLine($"Product Name: {product1.ProductName}\nPrice: ${product1.Price}");
            Console.ReadLine();
            Console.WriteLine($"Product Name: {product2.ProductName}\nPrice: ${product2.Price}");
            Console.ReadLine();
            Console.WriteLine($"Product Name: {product3.ProductName}\nPrice: ${product3.Price}");
            Console.ReadLine();

        }
    }
}
