using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp166
{
    class displayprogram
    {
        public void display()
        {
            Console.WriteLine("hello");
        }
    }
    internal class Program
    {
        
        static void Main()
        {
            displayprogram p = new displayprogram();
            p.display();
        }
    }
}
