using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 5;
            const int N = 6;
            int[,] arr0 = new int[M, N]
            {
                { 1,2,3,4,5,6 },
                { 1,2,4,5,2,6 },
                { 1,2,3,4,5,6 },
                { 1,2,3,4,5,6 },
                { 1,2,4,5,2,6 },
            };

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(arr0[i, j] + "  ");
                }
                Console.WriteLine();
            }

            int sameRows = 0;
            for (int i = 1; i < M; i++)
            {
                int temp = 0;
                for (int j = 0; j < N; j++)
                {
                    if (arr0[0, j] == arr0[i, j])
                    {
                        temp++;
                    }
                }
                if (temp == N) sameRows++;
            }
            Console.WriteLine("Рядкiв схожих на перший рядок: " + sameRows);

            sameRows = 0;
            for (int i = 0; i < M - 1; i++)
            {
                int temp = 0;
                for (int j = 0; j < N; j++)
                {
                    if (arr0[M - 1, j] == arr0[i, j])
                    {
                        temp++;
                    }
                }
                if (temp == N) sameRows++;
            }
            Console.WriteLine("Рядкiв схожих на останнiй рядок: " + sameRows + "\n");

            int[,] arr1 = new int[M, N]
            {
                { 1,6,3,1,1,6 },
                { 1,6,4,1,1,6 },
                { 1,6,3,1,1,6 },
                { 1,6,4,1,1,6 },
                { 1,6,3,1,1,6 },
            };

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(arr1[i, j] + "  ");
                }
                Console.WriteLine();
            }

            int sameCols = 0;
            for (int i = 1; i < N; i++)
            {
                int temp = 0;
                for (int j = 0; j < M; j++)
                {
                    if (arr1[j, 0] == arr1[j, i])
                    {
                        temp++;
                    }
                }
                if (temp == M) sameCols++;
            }
            Console.WriteLine("Стовцiв схожих на перший стовпець: " + sameCols);

            sameCols = 0;
            for (int i = 0; i < N - 1; i++)
            {
                int temp = 0;
                for (int j = 0; j < M; j++)
                {
                    if (arr1[j, N - 1] == arr1[j, i])
                    {
                        temp++;
                    }
                }
                if (temp == M) sameCols++;
            }
            Console.WriteLine("Стовцiв схожих на останнiй стовпець: " + sameCols);

            Console.ReadLine();
        }
    }
}








