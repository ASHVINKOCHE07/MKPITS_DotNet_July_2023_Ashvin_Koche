using System;

class SortString {
    static void Main(string[] args) {
        string str = "hello world"; // string to be sorted
        char[] charArray = str.ToCharArray(); // convert string to character array
        Array.Sort(charArray); // sort the character array
        string sortedStr = new string(charArray); // convert character array back to string

        Console.WriteLine("Sorted string: " + sortedStr);
    }
}