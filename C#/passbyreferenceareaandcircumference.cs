﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Calculate(int radius,ref float area,ref float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area=0,circ=0;
            Calculate(radius,ref area,ref circ);
            Console.WriteLine("area = " + area);
            Console.WriteLine("circumference = " + circ);
            Console.ReadKey();
        }

    }
}