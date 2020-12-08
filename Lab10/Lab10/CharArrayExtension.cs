using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    public static class CharArrayExtension
    {
        public static void Reverse(this char[] value1, char[] value2)
        {
            for (int i = value1.Length - 2; i > -1; i--)
            {
                Console.Write(value1[i]);
            }
            Console.Write(',');
            for (int i = value2.Length - 2; i > -1; i--)
            {
                Console.Write(value2[i]);
            }
            Console.WriteLine();
        }
        public static void ReverseR(this char[] value1, char[] value2, int i1, int i2)
        {
            ReverseR(value1, i1);
            Console.Write(',');
            ReverseR(value2, i2);

        }
        public static void ReverseR(this char[] value, int i)
        {
            if (i > -1)
            {
                Console.Write(value[i]);
                ReverseR(value, i - 1);
            }
        }
    }
}
