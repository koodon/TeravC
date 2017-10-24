using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] sent = new [] { "one", "two", "three" };

            for (int i = 0; i < sent.Length; i++)
            {
                Console.WriteLine(sent[i]);
            }
            Console.ReadLine();
        }
    }
}
