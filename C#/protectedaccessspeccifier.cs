using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp218
{
    class ProtectedTest
    {
        protected internal string name = "Shashikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            ProtectedTest pp = new ProtectedTest();
            pp.name = "ravi";
            Console.WriteLine(pp.name);

        }
    }
}
