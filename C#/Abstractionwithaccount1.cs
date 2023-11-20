using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp195
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract void deposit(int amt);
        public void showbalance()
        {
            Console.WriteLine("Balance amount for account no {0} is {1} :", actno, bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
        }
    }
    class Saving : Account
    {
        public override void deposit(int amt)
        {
            int interest = 200;
            bal = bal + amt + interest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No. :");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type saving or current");
            String acttype = Console.ReadLine();
            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            else
            {
                Console.WriteLine("Invalid input please run program again");
            }
            act.actno = actno;
            act.deposit(amt);
            act.showbalance();
            Console.ReadKey();
        }
    }
}
