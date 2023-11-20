using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp197
{

    abstract class account
    {
        public abstract void deposit(); //abstract method
        //non abstract method
        public void showbalance()
        {
            Console.WriteLine("balance method ");
        }

    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("hello from saving depsoit method");
        }
    }

   internal class Program
    {
        static void Main(string[] args)
        {
            //  account act = new account(); error 
            account act = new saving();
            act.deposit();
            act.showbalance();

        }

    }

}
