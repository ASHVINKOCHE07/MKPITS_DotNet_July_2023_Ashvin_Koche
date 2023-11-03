using System;

namespace ProductClass
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Default constructor
        public Product()
        {
            ProductId = 0;
            ProductName = "";
            Price = 0.0;
            Quantity = 0;
        }

        // Parameterized constructor
        public Product(int productId, string productName, double price, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Product object using the default constructor
            Product product1 = new Product();
            Console.WriteLine("Product 1:");
            Console.WriteLine("Product ID: {0}", product1.ProductId);
            Console.WriteLine("Product Name: {0}", product1.ProductName);
            Console.WriteLine("Price: {0}", product1.Price);
            Console.WriteLine("Quantity: {0}", product1.Quantity);

            // Create a new Product object using the parameterized constructor
            Product product2 = new Product(1, "Product 2", 10.99, 100);
            Console.WriteLine("Product 2:");
            Console.WriteLine("Product ID: {0}", product2.ProductId);
            Console.WriteLine("Product Name: {0}", product2.ProductName);
            Console.WriteLine("Price: {0}", product2.Price);
            Console.WriteLine("Quantity: {0}", product2.Quantity);

            Console.ReadLine();
        }
    }
}