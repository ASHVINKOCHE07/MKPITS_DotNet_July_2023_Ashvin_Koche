//second largest element in an array 
using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[5];
        int n, cnt = 0, max = 0, secondMax = 0;

        Console.Write("Enter the size of the array: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter the elements of the array: ");
        for (cnt = 0; cnt < n; cnt++) {
            arr[cnt] = int.Parse(Console.ReadLine());
        }

        for (cnt = 0; cnt < n; cnt++) {
            if (arr[cnt] > max) {
                secondMax = max;
                max = arr[cnt];
            } else if (arr[cnt] > secondMax && arr[cnt]!= max) {
                secondMax = arr[cnt];
            }
        }

        Console.WriteLine("The second largest element in the array is: " + secondMax);
    }
}