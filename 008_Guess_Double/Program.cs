using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Guess_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            double nr = 5.5;
            Console.WriteLine("Guess a double, from 1.0 - 10.0");

            while (true)
            {
                Console.Write("Guess double: ");
                double dbl = double.Parse(Console.ReadLine());
                {
                    if (nr == dbl)
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    else if (nr > dbl)
                    {
                        Console.WriteLine("Too Low!");
                    }
                    else if (nr < dbl)
                    {
                        Console.WriteLine("Too high!");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
