using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163
{
    class calculate
    {
        public void add(int n1, int n2)
        {
            Console.WriteLine("Addition of two numbers {0} and {1} = {2}", n1, n2, (n1 + n2));
        }
        public void add(float n1, float n2)
        {
            Console.WriteLine("Addition of two numbers {0} and {1} = {2}", n1, n2, (n1 + n2));
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            calculate c = new calculate(); 
            Console.WriteLine("Calling Int Method to  add ");
            c.add(3,2);
            Console.WriteLine("Calling Float Method");
            c.add(3.5f, 2.5f);
            Console.ReadKey();
        }
    }
}
