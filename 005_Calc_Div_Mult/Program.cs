﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Parse_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can calculate, I can divide and multiplie!");
            Console.WriteLine("");
            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Dividing " + num1 + " and " + num2 + " = " + num1 / num2);
            Console.WriteLine("Multiplying " + num1 + " and " + num2 + " = " + num1 * num2);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
