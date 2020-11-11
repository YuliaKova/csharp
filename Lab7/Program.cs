using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("How many elements will be in the collection?");
            int length;
            do
            {
                length = Int32.Parse(Console.ReadLine());
                if (length < 1) Console.WriteLine("Wrong number! Try again:");
            } while (length < 1);

            Console.WriteLine("Put in the numbers:");
            for (int i = 0; i < length; i++)
            {
                int a;
                do
                {
                    a = Int32.Parse(Console.ReadLine());
                    if (a < 0 || a > 9) Console.WriteLine("Wrong number! Try again:");
                } while (a < 0 || a > 9);
                numbers.Add(a);
            }

            int[] amount = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int counter = 0;
                for (int j = 0; j < length; j++)
                {
                    if (numbers[j] == i)
                    {
                        counter++;
                    }
                }
                amount[i] = counter;
            }
            Console.WriteLine("\nHow many times every number appeared:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                Console.WriteLine(" | " + amount[i]);
            }

            Console.ReadKey();
        }
    }
}
