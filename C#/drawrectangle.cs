using System;

// Define the IDrawable interface
public interface IDrawable
{
    void Draw();
}

// Implement the IDrawable interface in the Circle class
public class Circle : IDrawable
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a circle with radius " + radius);
    }
}

// Demonstrate how a class that implements IDrawable can also implement other interfaces
public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle with width " + width + " and height " + height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Circle object and call its Draw method
        Circle circle = new Circle(5);
        circle.Draw();

        // Create a Rectangle object and call its Draw method
        Rectangle rectangle = new Rectangle(10, 5);
        rectangle.Draw();
    }
}