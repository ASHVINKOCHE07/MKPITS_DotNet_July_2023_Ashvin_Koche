using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int cnt = 0; cnt < n; cnt++)
        {
            arr[cnt] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int cnt = 0; cnt < n; cnt++)
        {
            sum += arr[cnt];
        }

        Console.WriteLine("The sum of all elements in the array is: " + sum);
    }
}