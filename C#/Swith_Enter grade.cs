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
            string grade;
            Console.WriteLine("Enter grade E,V,G,A,F :");
            grade= Console.ReadLine();
            switch (grade)
            {
                case "E":
                    Console.WriteLine("grade = Excellent");
                    break;
                case "V":
                    Console.WriteLine("grade = Very Good");
                    break;
                case "G":
                    Console.WriteLine("grade = Good");
                    break;
                case "A":
                    Console.WriteLine("grade = Average");
                    break;
                case "F":
                    Console.WriteLine("grade = Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
            Console.ReadKey();
        }

    }
}