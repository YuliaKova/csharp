using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3526;

            int b = a/100;
            int c = a % 100;

            if ((b/10)+(b%10)==(c/10)+(c%10))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();
        }
    }
}
