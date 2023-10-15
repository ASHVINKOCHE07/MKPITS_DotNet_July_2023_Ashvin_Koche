using System;

namespace ProfitAndLossCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the cost price: ");
            double cp = double.Parse(Console.ReadLine());

            Console.Write("Enter the selling price: ");
            double sp = double.Parse(Console.ReadLine());

            double profit = sp - cp;
            double loss = cp - sp;

            if (profit > 0)
            {
                Console.WriteLine("Profit: " + profit);
            }
            else if (loss > 0)
            {
                Console.WriteLine("Loss: " + loss);
            }
            else
            {
                Console.WriteLine("No profit or loss.");
            }
        }
    }
}