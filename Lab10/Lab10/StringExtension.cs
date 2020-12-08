using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    public static class StringExtension
    {
        public static void Reverse(this string value)
        {
            for (int i = value.Length - 1; i > -1; i--)
            {
                Console.Write(value[i]);
            }
            Console.WriteLine();
        }
        public static void ReverseR(this string value, int i)
        {
            if (i > -1)
            {
                Console.Write(value[i]);
                ReverseR(value, i - 1);
            }
        }
    }
}
