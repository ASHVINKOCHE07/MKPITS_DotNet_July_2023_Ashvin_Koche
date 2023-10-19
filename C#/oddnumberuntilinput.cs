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
            int number;
            int counter = 1;
            Console.WriteLine("Enter Number");
            number=Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            while (true)
            {
                if (sum <= number)
                {

                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("Odd No:{0}", counter);
                        sum = sum + 1;
                    }
                } else {

                    break;
                }
                counter++;
            }
            Console.ReadKey();
        }

    }
}