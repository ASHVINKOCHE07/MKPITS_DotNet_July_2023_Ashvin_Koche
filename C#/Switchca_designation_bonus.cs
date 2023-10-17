using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int bonus=0;
            string designation;
            Console.WriteLine("Enter Designation (maneger,clerk or peon) : ");
            designation = Console.ReadLine();
            switch (designation)
            {
                case "maneger":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 1500;
                    break;
                default:
                    Console.WriteLine("Invalid designation.");
                    break;

            }
            Console.WriteLine("bonus = {0} for {1} .",bonus,designation
                );
            Console.ReadKey();
        }
        
    }
}