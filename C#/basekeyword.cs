using ConsoleApp210;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp210
{
    class Animal
    {
        public String color = "white";
    }
    class Dog : Animal
    {
        public String color = "red";

        public void displaycolor()
        {
            Console.WriteLine("Dog color : " + color);
            Console.WriteLine("Animal color : " + base.color);
        }
    }
    internal class Program
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.displaycolor();
            Console.ReadKey();
        }
    }
}
