using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp193
{
    abstract class Shape
    {
        public abstract void draw();
    }
    class Square : Shape
    {
      public override void draw()
        {
            Console.WriteLine("//CODE TO DRAW SQUARE");
        }
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("//CODE TO DRAW RECTANGLE");
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle();
            shape.draw();
            Shape shape1 = new Square();
            shape1.draw();
            Console.ReadLine();
        }
    }
}
