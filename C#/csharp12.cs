using System;
namespace namespace1
{
    class operationsoftwonos
    {
        public static void Main()
        {
            int num1, num2, res;
            Console.WriteLine("Enter 1st Number = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number = ");
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine("{0} + + num2 = +res);
            res = num1 - num2;
            Console.WriteLine(+num1 "-" +num2 =  +res);
            res = num1 * num2;
            Console.WriteLine(+num1 "*" +num2 = +res);
            res = num1 / num2;
            Console.WriteLine(+num1 "/" +num2 = +res);
            res = num1 % num2;
            Console.WriteLine(+num1"mod" + num2 = +res);
            Console.ReadKey();
        }
    }
}
