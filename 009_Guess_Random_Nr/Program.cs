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
            Console.WriteLine("I will choose random number [1-100]. Try to guess it!");
            Random rNr = new Random();
            int nr = rNr.Next(1, 101);
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