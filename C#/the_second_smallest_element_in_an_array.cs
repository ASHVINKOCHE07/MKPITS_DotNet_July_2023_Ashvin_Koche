//the second smallest element in an array
using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[5];
        int n, cnt = 0, min, secondMin;

        Console.Write("Enter the size of the array: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter the elements of the array: ");
        for (cnt = 0; cnt < n; cnt++) {
            arr[cnt] = int.Parse(Console.ReadLine());
        }

        min = arr[0];
        secondMin = arr[1];

        for (cnt = 0; cnt < n; cnt++) {
            if (arr[cnt] < min) {
                secondMin = min;
                min = arr[cnt];
            } else if (arr[cnt] < secondMin && arr[cnt]!= min) {
                secondMin = arr[cnt];
            }
        }

        Console.WriteLine("The second smallest element in the array is: " + secondMin);
    }
}