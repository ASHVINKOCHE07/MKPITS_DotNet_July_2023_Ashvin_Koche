using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp184
{
    class Baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("hello from base class show method");
        }
    }
    class Childclass : Baseclass
    {
        public override void show()
        {
            Console.WriteLine("hello from child class show method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Baseclass b = new Childclass();
            b.show();
            Console.ReadKey();
        }
    }
}
