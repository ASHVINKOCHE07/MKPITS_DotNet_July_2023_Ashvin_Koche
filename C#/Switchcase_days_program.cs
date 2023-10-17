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
            int noday;
            Console.Write("Enter no of day as per week = ");
            noday = Convert.ToInt32(Console.ReadLine());
            switch(noday) {
                case 1:
                    Console.WriteLine("Day = Monday");
                    break;
                case 2:
                    Console.WriteLine("Day = Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day = Wednasday");
                    break;
                case 4:
                    Console.WriteLine("Day = thursday");
                    break;
                case 5:
                    Console.WriteLine("Day = Friday");
                    break;
                case 6:
                    Console.WriteLine("Day = Saturday");
                    break;
                case 7:
                    Console.WriteLine("Day = Sunday");
                    break;
                default:
                    Console.WriteLine("Some other day....");
                    break;

            }
        }
    }
}