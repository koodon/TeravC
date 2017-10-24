using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Guess_Random_Nr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I give You Random Number!");
            string[] sent = new[] { "one", "two", "three" };
            Random stuff = new Random($" {0}. {sent}");

            //Random rNr = new Random();
            //int nr = rNr.Next(1, 101);
            //int rNumber = new Random().Next(1, 101);

            while (true)
            {
                Console.Write("Guess number: ");
                int gNr = int.Parse(Console.ReadLine());
                {
                    if (nr == gNr)
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    else if (nr < gNr)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else if (nr > gNr)
                    {
                        Console.WriteLine("Too low!");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}