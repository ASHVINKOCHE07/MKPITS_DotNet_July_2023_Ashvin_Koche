using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_table_vertically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("Enter Limit: ");
            flag = Convert.ToInt32(Console.ReadLine());
            for (int counter= 1; counter <= 10; counter++) 
            { 
                for (int counter1 = 1;counter1 <= flag;counter1++)
                {
                    Console.Write("{0} * {1} = {2} ", counter1, counter, (counter1 * counter));
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


