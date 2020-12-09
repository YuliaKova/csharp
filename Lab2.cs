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
            double dob = 1;

            for (int k = 1; k < 10; k++)
            {
                dob *= (Math.Pow(-1,k*k+k+1)*k*k) / (2*k*k+5);
            }
            Console.Write("\nДобуток ряду дорiвнює ");
            Console.WriteLine(dob);

            Console.ReadLine();
        }
    }
}
