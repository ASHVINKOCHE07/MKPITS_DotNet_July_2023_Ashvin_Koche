using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,choice;
            Console.Write("Enter num 1 :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 2 :");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculator menu = ");
            Console.WriteLine("Press 1 for Addition = ");
            Console.WriteLine("Press 2 for Subtraction =  ");
            Console.WriteLine("Press 3 for Divison =  ");
            Console.WriteLine("Press 4 for Multiplication =  ");
            Console.Write("Enter choice = ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " +(n1 + n2));
                    break;
                case 2:
                    Console.WriteLine("Result = " + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine("Result = " + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine("Result = " + (n1 / n2));
                    break;
                default:
                    Console.WriteLine("Invalid Input....");
                    break;

            }
            Console.ReadKey();
        }
    }
}

