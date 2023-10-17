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
            int counter = 20;
            while (counter < 30)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++; 
            }


            Console.ReadKey();
        }
    }
}
