using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp198
{
    abstract class account
    {
        public int bal = 1000;
        public abstract void deposit(int amount);
        public abstract void withdrawl(int amount);
        public void showbalance()
        {
            Console.WriteLine("bal is " + bal);
        }
    }
    class saving : account
    {
        public override void withdrawl(int amount)
        {
            bal = bal - amount;
        }
        public override void deposit(int amount)
        {
            int interest = 500;
            bal = bal + amount + interest;
            Console.WriteLine("amount deposited with interest, bal is " + bal);
        }
    }

    class current : account
    {
        public override void withdrawl(int amount)
        {
            bal = bal - amount;

        }
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("amount deposited without interest bal is " + bal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            account act = null;
            Console.WriteLine("enter amount ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            Console.WriteLine("enter deposit or withdrawl");
            string tt = Console.ReadLine();
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }

            if (tt == "deposit")
            {
                act.deposit(amount);
            }
            else if (tt == "withdrawl")
            {
                act.withdrawl(amount);
            }
            act.showbalance();

            Console.ReadLine();
        }
    }
}
