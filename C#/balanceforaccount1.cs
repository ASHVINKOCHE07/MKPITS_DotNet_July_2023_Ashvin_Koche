using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp206
{
    interface bank
    {
        String deposit(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;
    }
    class saving:account,bank
    {
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully , bal is" + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b;
            b= new saving();  
            string Str = b.deposit(1, 200);
            Console.WriteLine(Str);
            Console.ReadLine();
        }
    }
}
