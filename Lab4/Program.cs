using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int k = 3;
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = i;
            }

            Console.Write("Array: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }

            for (int i = 0; i < k; i++)
            {
                int temp = arr[0];
                arr[0] = arr[N - 1];
                for (int j = 1; j < N-1; j++)
                {

                    arr[N - j] = arr[N - j - 1];
                }
                arr[1] = temp;
            }

            Console.Write("\nResult: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
