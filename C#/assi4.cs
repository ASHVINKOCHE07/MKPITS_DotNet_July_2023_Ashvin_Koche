using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int cnt1 = 0; cnt1 < size; cnt1++) {
            arr[cnt1] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Unique elements in the array:");
        for (int cnt1 = 0; cnt1 < size; cnt1++) {
            bool isUnique = true;
            for (int cnt2 = 0; cnt2 < cnt1; cnt2++) {
                if (arr[cnt1] == arr[cnt2]) {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique) {
                Console.WriteLine(arr[cnt1]);
            }
        }
    }
}