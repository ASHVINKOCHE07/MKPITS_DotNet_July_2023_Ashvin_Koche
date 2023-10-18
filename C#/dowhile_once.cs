using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_5num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 11;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5);
            Console.ReadKey();
        }
    }
}
