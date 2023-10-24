using System;

class TrigonometryAngles {
    static void Main(string[] args) {
        double angle1 = 60; // angle in degrees
        double angle2 = 30; // angle in degrees
        double angle1Rad = angle1 * Math.PI / 180; // convert angle1 to radians
        double angle2Rad = angle2 * Math.PI / 180; // convert angle2 to radians

        Console.WriteLine("Angle 1 (degrees): " + angle1);
        Console.WriteLine("Angle 2 (degrees): " + angle2);
        Console.WriteLine("Angle 1 (radians): " + angle1Rad);
        Console.WriteLine("Angle 2 (radians): " + angle2Rad);

        Console.WriteLine("sin(Angle 1) = " + Math.Sin(angle1Rad));
        Console.WriteLine("sin(Angle 2) = " + Math.Sin(angle2Rad));
        Console.WriteLine("cos(Angle 1) = " + Math.Cos(angle1Rad));
        Console.WriteLine("cos(Angle 2) = " + Math.Cos(angle2Rad));
        Console.WriteLine("tan(Angle 1) = " + Math.Tan(angle1Rad));
        Console.WriteLine("tan(Angle 2) = " + Math.Tan(angle2Rad));
    }
}