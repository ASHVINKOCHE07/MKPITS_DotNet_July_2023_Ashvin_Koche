using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp164
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor called");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor Called");
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                Console.ReadKey();
                Employee emp1 = new Employee();
                Console.ReadKey();
            }
        }
    }

