using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 0;
            const double g = 9.81;
            double h = 10;
            t = Math.Sqrt((2 * h) / g);

            Console.Write("Час вiльного падiння дорiвнює ");
            Console.Write(t);
            Console.WriteLine(" при початковiй швидкостi 0 та висотi 10м.");
            
            Console.ReadLine();
        }
    }
}
