using System;

namespace Lab6
{
    class Program
    {
        static void Reverse(string value)
        {
            for (int i = value.Length - 1; i > -1; i--)
            {
                Console.Write(value[i]);
            }
            Console.WriteLine();
        }

        static void Reverse(char[] value1, char[] value2)
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

        static void ReverseR(string value, int i)
        {
            if (i > -1)
            {
                Console.Write(value[i]);
                ReverseR(value, i - 1);
            }
        }

        static void ReverseR(char[] value1, char[] value2, int i1, int i2)
        {
            ReverseR(value1, i1);
            Console.Write(',');
            ReverseR(value2, i2);

        }
        static void ReverseR(char[] value, int i)
        {
            if (i > -1)
            {
                Console.Write(value[i]);
                ReverseR(value, i - 1);
            }
        }

        static void refReverse(ref char[] value)
        {
            char[] temp = new char[value.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = value[i];
            }

            for (int i = 0, j = temp.Length - 2; i < value.Length - 1; i++, j--)
            {
                value[i] = temp[j];
            }

            Console.WriteLine(value);
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;     //кодування консолі при запису виводу
            Console.InputEncoding = System.Text.Encoding.Unicode;      //кодування консолі при зчитуванні вводу

            Console.WriteLine("Введіть число або рядок (без розділових знаків та пробілів):");
            string data = Console.ReadLine();

            Console.WriteLine("\nРезультат:");
            Reverse(data);
            Console.WriteLine("Результат (рекурсія):");
            ReverseR(data, data.Length - 1);

            char[] chData = new char[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                chData[i] = data[i];
            }

            Console.WriteLine("\n\nМасив навпаки:");
            refReverse(ref chData);

            Console.WriteLine("\n\nВведіть дробове число або рядок з ОДНІЄЮ комою всередині (без пробілів):");
            string data1 = Console.ReadLine();

            int size = 0;
            for (int i = 0; i < data1.Length; i++)
            {
                if (data1[i] == ',')
                {
                    size = i;
                    break;
                }
            }

            char[] data1_1 = new char[size + 1];
            char[] data1_2 = new char[data1.Length - size];

            for (int i = 0; i < size; i++)
            {
                data1_1[i] = data1[i];
            }
            for (int i = size + 1, j = 0; i < data1.Length; i++, j++)
            {
                data1_2[j] = data1[i];
            }

            Console.WriteLine("\nРезультат:");
            Reverse(data1_1, data1_2);
            Console.WriteLine("Результат (рекурсія):");
            ReverseR(data1_1, data1_2, data1_1.Length - 2, data1_2.Length - 2);

            Console.ReadKey();
        }
    }
}
