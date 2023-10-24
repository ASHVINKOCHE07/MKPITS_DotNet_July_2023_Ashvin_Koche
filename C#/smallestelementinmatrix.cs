using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[,]
        {
            { 10, 20, 30 },
            { 40, 50, 60 },
            { 70, 80, 90 }
        };

        int min = matrix[0, 0];
        int count1, count2;

        for (count1 = 0; count1 < matrix.GetLength(0); count1++)
        {
            for (count2 = 0; count2 < matrix.GetLength(1); count2++)
            {
                if (matrix[count1, count2] < min)
                {
                    min = matrix[count1, count2];
                }
            }
        }

        Console.WriteLine("Smallest element in the matrix is: " + min);
    }
}