using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void display(int actno, int amount,int depo1) {
            int bal = amount;
            int with;
            Console.WriteLine("Balance before deposit or withdrawl = "+bal);
            
            bal = bal + depo1;
            Console.WriteLine("Balance after deposit or withdrawl = " +bal);
            Console.Write("Enter amount to be withdrawl =");
            with=Convert.ToInt32(Console.ReadLine());
            bal =bal - with;
            Console.WriteLine("Details are as follows = ");
            Console.WriteLine ("Account Number = "+actno);
            Console.WriteLine("Account Balance = "+bal);
            Console.WriteLine("Account Deposit = "+depo1);
            Console.WriteLine("Account withdrawl = "+with);



        }
        static void Main(string[] args)
        {
            int actno1,amt,depo;
            Console.WriteLine("Enter Details (actno,amount,deposit amount ");
            actno1 = Convert.ToInt32(Console.ReadLine());
            amt = Convert.ToInt32(Console.ReadLine());
            depo = Convert.ToInt32(Console.ReadLine());

            display(actno1,amt,depo);



            Console.ReadKey();
        }

    }
}