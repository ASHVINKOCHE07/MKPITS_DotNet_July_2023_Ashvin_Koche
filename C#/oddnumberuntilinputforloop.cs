using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (counter = 1 ;true; counter++)
            {
                if (sum <= number)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("odd no : {0}", counter);
                        sum = sum + 1;

                    }

                }
                else
                {
                    break;
                }
                
            }

            Console.ReadKey();
        }
    }
}

