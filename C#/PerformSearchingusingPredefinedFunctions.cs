using System;

class SearchString {
    static void Main(string[] args) {
        string str = "hello world"; // string to be searched
        char[] charArray = str.ToCharArray(); // convert string to character array
        char searchChar = 'o'; // character to be searched

        int index = Array.IndexOf(charArray, searchChar); // search for character in array

        if (index == -1) {
            Console.WriteLine("Character not found in string.");
        } else {
            Console.WriteLine("Character found at index " + index);
        }
    }
}