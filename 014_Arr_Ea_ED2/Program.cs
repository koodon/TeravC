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
            string[] sent = new[] { "one", "two", "three" };

            int i = 1;
            foreach (string word in sent)
            {
                Console.WriteLine(i + " = " + word);
                i++;
            }
            Console.ReadLine();
        }
    }
}
