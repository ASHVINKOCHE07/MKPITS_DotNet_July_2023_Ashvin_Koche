using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp217
{
    class PublicTest
    {
        public string name = "aston robert";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello"+msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest publicTest= new PublicTest();
            Console.WriteLine("Hello"+publicTest.name);
            publicTest.Msg("radon");
        }
    }
}
