/*
 * C# Program to Find Value of 1/(1+x2) using Simpsons 1/3 Rule
 */
using System;
 
class simpson
{
    float a, b;
    int n;
    public void readdata()
    {
        Console.WriteLine("Enter the Lower Limit Value : ");
        a = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the Upper Limit Value : ");
        b = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the Number of Intervals : ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    public void simp()
    {
        int i;
        float x, sum = 0.0f, h;
        float[] y = new float[n + 1];
        h = (b - a) / n;
        x = a;
        for (i = 0; i <= n; i++)
        {
            y[i] = 1.0f / (1 + x * x);
            x = x + h;
        }
        sum = y[0] + y[n];
        for (i = 1; i < n - 1; i += 2)
        {
            sum += 4 * y[i]+2* y[i + 1];
 
        }
        sum = sum * h / 3.0f;
        Console.WriteLine("Integral Value : {0} ", sum);
        Console.ReadLine();
    }
    public static void Main()
    {
        simpson obj = new simpson();
        obj.readdata();
        obj.simp();
    }
}