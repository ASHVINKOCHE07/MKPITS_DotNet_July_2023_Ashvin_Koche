using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp161
{
    internal class static_constructor
    {
        class Employee
        {
            static Employee()
            {
                Console.WriteLine("Static Constructor");
                Console.WriteLine("Static Constructor with no data and parameters");
            }
            public static void salary() 
            {
                Console.WriteLine("Salary method executed");
            }        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Static variable method applied.");
            Console.WriteLine("_______________________________");
            Employee.salary();
            Console.ReadKey();
        }
    }
}
