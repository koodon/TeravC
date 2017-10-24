﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Guess_Nr
{
    class Program
    {
        static void Main(string[] args)
        {
            int rightNr = 77;
            Console.WriteLine("I will choose a number [1-100]. Try to guess it!");
            
            while (true)
            {
                Console.Write("Your number: ");
                int nr = int.Parse(Console.ReadLine());

                if (nr < rightNr)
                {
                    Console.WriteLine("Your number is is too low!");                  
                }
                else if (nr > rightNr)
                {
                    Console.WriteLine("Your number is too high!");
                }
                else if (nr == rightNr)
                {
                    Console.WriteLine("Congratulations, You hit the jackpot!");
                    break;
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
