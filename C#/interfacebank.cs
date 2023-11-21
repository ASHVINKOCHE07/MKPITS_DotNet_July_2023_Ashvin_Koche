using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp204
{
    interface Bank
    {
        String deposit(int actno, int amt);
    }
    class Saving : Bank
    {
        int actno;
        int bal = 1000;
        public String deposit (int actno,int amt)
        {
            this.actno = actno;
            bal=bal+amt;
            return "deposited sucessfully , bal is "+bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b=new Saving();
            String  str=b.deposit(1, 2000);
            Console.WriteLine(str);
        }
    }
}
