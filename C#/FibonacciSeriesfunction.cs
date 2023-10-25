using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        DisplayFibonacciSeries(n);
    }

    static void DisplayFibonacciSeries(int n)
    {
        int a = 0, b = 1, c, count = 1;

        Console.WriteLine("Fibonacci Series:");
        while (count <= n)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
            count++;
        }
    }
}