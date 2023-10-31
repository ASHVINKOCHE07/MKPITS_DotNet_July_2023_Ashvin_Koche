using System;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Product product = new Product
        {
            Name = "Laptop",
            Price = 1500,
            StockQuantity = 50
        };

        Console.WriteLine("Initial Stock Quantity: " + product.StockQuantity);

        int quantityToBuy = 5;
        int newStockQuantity = product.StockQuantity - quantityToBuy;

        if (newStockQuantity >= 0)
        {
            product.StockQuantity = newStockQuantity;
            Console.WriteLine("Updated Stock Quantity: " + Convert.ToInt32(product.StockQuantity));
        }
        else
        {
            Console.WriteLine("Insufficient Stock");
        }
    }
}