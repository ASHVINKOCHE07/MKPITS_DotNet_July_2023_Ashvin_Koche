using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int cnt = 0; cnt < size; cnt++)
        {
            arr[cnt] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for (int cnt = 0; cnt < size; cnt++)
        {
            sum += arr[cnt];
        }
        Console.WriteLine("The sum of all elements in the array is: " + sum);
    }
}