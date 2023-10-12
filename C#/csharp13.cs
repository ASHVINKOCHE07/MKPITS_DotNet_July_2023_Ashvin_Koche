using System;
namespace characcept 
{
    class A1
    {
        public static void Main()
        {
            char ch;
            Console.WriteLine("Enter character");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Entered Character = "+ch);
            Console.ReadKey();
        }
    }
}