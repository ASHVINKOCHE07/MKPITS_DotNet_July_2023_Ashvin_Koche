using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int sum = 0;

        for (int cnt = 0; cnt < matrix.GetLength(0); cnt++)
        {
            sum += matrix[cnt, cnt];
        }

        Console.WriteLine("The sum of the left diagonal is: " + sum);
    }
}
