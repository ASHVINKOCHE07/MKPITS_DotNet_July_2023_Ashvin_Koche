using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            try
            {
                Console.WriteLine("Enter age : ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new Exception("Age should be greater than or equal to 18 ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Enter age above or equal to  18 : ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("finally block is executing.");
                Console.WriteLine("age = "+age);
            }
            Console.WriteLine("End of program.");
            Console.ReadKey();
            }
        }
    }

