using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp185
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating.......");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread.........");
        }
    }
    internal class Testpolymorphisum
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.eat();
        }
    }
}
