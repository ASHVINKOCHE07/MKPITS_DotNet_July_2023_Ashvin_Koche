using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp177
{
    class Employee
    {
        protected int salary;
    }
    class Programeer : Employee
    {
        int bonus;
        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary : " + salary);
            Console.WriteLine("bonus : "+bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programeer p = new Programeer();
            p.getdata(50000,5000);
            p.displaydata();
        }
    }
}
