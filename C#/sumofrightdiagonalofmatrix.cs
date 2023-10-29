using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows for the matrix:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns for the matrix:");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the elements of the matrix:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int sum = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    sum += matrix[i, j];
                }
            }
        }

        Console.WriteLine("The sum of the right diagonals of the matrix is: " + sum);
    }
}