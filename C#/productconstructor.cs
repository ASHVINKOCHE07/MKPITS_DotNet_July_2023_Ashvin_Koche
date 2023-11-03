using System;

namespace ProductClass
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            ProductId = 1;
            ProductName = "Product A";
            Price = 10.99;
            Quantity = 100;
        }

        public void Display()
        {
            Console.WriteLine("Product ID: " + ProductId);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Display();
        }
    }
}