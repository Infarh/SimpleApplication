using System;

namespace TestApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Комментарий в одной строке
            //Console.WriteLine();
            Console.WriteLine("Hello World!!!"); // Вывод строки

            /*
             
             Многострочный коментарий
             
             */
            // Ctrl+K,D
            string str, str2 = "qwe", str3 = str2;

            str = Console.ReadLine();

            Console.WriteLine("Пользователь ввёл: " + str);

            int i32; // 4 байта со знаком
            long l64; // 8 байт со знаком
            short sh16; // 2 байта со знаком
            byte b; // 1 байт БЕЗ ЗНАКА 0..255

            uint ui32;
            ulong ul64;
            ushort ush16;
            sbyte sb;     // -128..127

            double dbl = 3.14159265358979323846; // 8 байт
            float sg;   // 4 байта

            bool bl = true;  // true/false  4 байта

            bl = dbl < 0;
            // >
            // <
            // >=
            // <=
            // ==
            // !=
            // !true == false
            char ch = 'q'; // 1 байт

            if (dbl <= 0)
            {
                int qwe = 42;
                Console.WriteLine("dbl = " + dbl + " меньше либо равно 0");
            }
            else
            {
                Console.WriteLine("dbl = " + dbl + " больше 0");
            }

            for (int i = 0; i < 10; i++) // i = i + 1
            {
                Console.Write(i);
                Console.Write(",");
            }

            //while (dbl > 0)
            //{

            //}

            //do
            //{

            //} while (true);

            Console.Write("Введите кол-во эл-тов массива>");
            str = Console.ReadLine();

            int N = int.Parse(str);

            str = N.ToString();

            double[] double_array = new double[N];
            for (int i = 0; i < double_array.Length; i++)
            {
                double_array[i] = i * i;
            }

            Console.ReadLine();
        }
    }
}
