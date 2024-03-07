using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- WEL COME TO SHOP -----");

            
            Product[] products = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                products[i] = new Product
                {
                    ProductId = i + 1,
                    ProductName = Console.ReadLine(),
                    Price = GetValidDoubleInput("Enter Price: ")
                };
            }

            // Sort products based on price
            Array.Sort(products, (p1, p2) => p1.Price.CompareTo(p2.Price));

            // Display sorted products
            Console.WriteLine("\nSorted Products based on Price:");
            double totalPrice = 0;

            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price:C}");
            }

            Console.WriteLine("----- Total Price of all products -----");
            Console.WriteLine($"\nTotal Price : {totalPrice:C}");

            Console.WriteLine("----- THANK YOU -----");
            Console.WriteLine("      VISIT AGAIN      ");


            Console.ReadLine();
        }

        static double GetValidDoubleInput(string prompt)
        {
            double result;
            do
            {
                Console.Write(prompt);
            } while (!double.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }
}
