using System;

namespace Palindrome
{
    class Program
    {
        static bool IsPalindrome(string str)
        {
            int i = 0, j = str.Length - 1;
            while (i < j)
            {
                if (str[i]!= str[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string str = "racecar";
            if (IsPalindrome(str))
            {
                Console.WriteLine(str + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(str + " is not a palindrome.");
            }
        }
    }