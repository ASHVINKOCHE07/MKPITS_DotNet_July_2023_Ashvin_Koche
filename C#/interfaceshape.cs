using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp202
{
    interface Shape
    {
        void draw();
    }
    class Rectangle:Shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of rectsngle class");
        }
    }
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of circle class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle();
            shape.draw();
            shape= new Circle();
            shape.draw();
        }
    }
}
