using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp176
{
    public class Employee
    {
        public float salary = 75000;
    }
    public class Programmer : Employee
    {
        public float bonus = 10000;
    }
    internal class Testinheritance
    {
        static void Main(string[] args)
        {
            Programmer p1=new Programmer();
            Console.WriteLine("Salary : "+p1.salary);
            Console.WriteLine("Bonus : " + p1.bonus);
        }
    }
}
