using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp171
{
    public class Account
    {
        public int accno;
        public String name;
        public static float roi = 8.8f;
        public Account (int accno,String name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno+" "+name+" "+roi);
        }
    }
    internal class TestAccount
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "sono");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
        }
    }
}
