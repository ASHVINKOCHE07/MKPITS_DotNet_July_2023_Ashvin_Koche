using System;

namespace ElectricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter customer ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter unit consumed: ");
            double unit = double.Parse(Console.ReadLine());

            double bill = 0;
            if (unit <= 199)
            {
                bill = unit * 1.2;
            }
            else if (unit <= 399)
            {
                bill = unit * 1.5;
            }
            else if (unit <= 599)
            {
                bill = unit * 1.8;
            }
            else
            {
                bill = unit * 2.0;
            }

            if (bill > 400)
            {
                bill += bill * 0.15;
                if (bill < 100)
                {
                    bill = 100;
                }
            }

            Console.WriteLine("Electricity Bill of " + name + " (ID: " + id + ")");
            Console.WriteLine("Unit Consumed: " + unit);
            Console.WriteLine("Total Amount Due: Rs. " + bill);
        }
    }
}
