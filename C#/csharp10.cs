using System;
namespace swap
{
    class programofswappingoftwonumbers
    {
        public static void Main()
        {
            int num1, num2, s;
            Console.WriteLine("Enter First Num = ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Num = ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Swapping Started");
            s = num1;
            num1 = num2;
            num2 = s;
            Console.WriteLine("After Swapping = ");
            Console.WriteLine("First Num = " +num1);
            Console.WriteLine("Second Num = " +num2);
            Console.ReadKey();

        }
    }
}
