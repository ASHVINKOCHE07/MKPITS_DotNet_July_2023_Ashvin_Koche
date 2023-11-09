using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp172
{
    public class Account
    {
        public int accno;
        public string name;
        public static int count = 0;
        public Account(int accno,String name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(accno+""+name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101,"sonoo");
            Account a2 = new Account(102, "Mahesh");
            Account a3 = new Account(103, "Ajeet");
            a1.display();
            a2.display();
            a3.display();
            Console.ReadKey();
        }
    }
}
