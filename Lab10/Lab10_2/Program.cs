using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Variant 10

namespace Lab10_2
{
    public static class IntArrayExtention
    {
        public static void DoubleEveryElement(this int[] arr1, int[] arr2)
        {
            for(int i = 0; i < arr1.Length; i++)
            {
                for (int j = i*2; j < (i*2)+2; j++)
                {
                    arr2[j] = arr1[i];
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;

            int[] arr1 = new int[n] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[n * 2];

            Console.Write("arr1:\t");
            foreach (int i in arr1)
            {
                Console.Write(i + "\t");
            }

            arr1.DoubleEveryElement(arr2);

            Console.Write("\n\narr2:\t");
            foreach (int i in arr2)
            {
                Console.Write(i + "\t");
            }

            Console.ReadLine();
        }
    }
}
