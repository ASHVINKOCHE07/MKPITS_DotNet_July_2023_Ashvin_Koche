using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp245
{
    internal class Program
    { 

         class Calculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }
                return a / b;
            }

            public static void Main()
            {
                while (true)
                {

                    try
                    {
                        Console.Write("Enter first number: ");
                        double num1 = double.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        double num2 = double.Parse(Console.ReadLine());

                         Console.Write("Enter operation (+, -, *, /): ");
                         char op = char.Parse(Console.ReadLine());

                          double result = 0;

                        switch (op)
                        {
                            case '+':
                                result = Add(num1, num2);
                                break;
                            case '-':
                                result = Subtract(num1, num2);
                                break;
                            case '*':
                                result = Multiply(num1, num2);
                                break;
                            case '/':
                                result = Divide(num1, num2);
                                break;
                            default:
                                throw new ArgumentException("Invalid operation");
                        }

                        Console.WriteLine("Result: " + result);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Invalid operation. Please enter a valid operation (+, -, *, /).");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    finally
                    {
                        Console.WriteLine("Exiting program...");
                    }
                }
            }
        }
    }
    }

