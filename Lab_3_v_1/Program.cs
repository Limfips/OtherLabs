using System;

namespace Lab_3_v_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Дудка Леонид, Вариант 6:
             * 1-1;
             * 2-5;
             * 3-3;
             * 4-4;
             */
            Console.Write("Задание 1(1): ");
            Console.Write("введите натуральное число n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tРезультат 1 задания: ");
            Ex1_1_Squares(n);
            Console.WriteLine();
            Console.Write("Задание 2(5): ");
            Console.WriteLine("Введите любое число кроме 0: ");
            Console.WriteLine("\tМаксимальное отрицательное: {0}",Ex2_5());
            Console.Write("Задание 3(3): ");
            Console.Write("введите натуральное число n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tРезультат 3 задания: ");
            Console.WriteLine(Reverse(n));
            Ex3_3_Reverse(ref n);
            Console.WriteLine("Задание 4(4): ");
            Ex4_4();
        }

        private static void Ex1_1_Squares(int n)
        {
            double result;
            for (int i = 1; (result = Math.Pow(i, 2.0)) < n; i++)
            {
                Console.Write(result + " ");
            }
        }

        private static int Ex2_5()
        {
            int x;
            var maxNegative = 0;
            do
            {
                Console.Write("\t\t\t");
                x = Convert.ToInt32(Console.ReadLine());

                if (x<maxNegative) maxNegative = x;
                
            } while (x != 0);

            return maxNegative;
        }

        private static void Ex3_3_Reverse(ref int n)
        {
            long time1, time2;
            time1 = DateTime.Now.Millisecond;
            for (var i = 0; i < 1000000; i++) Reverse(n);
            time2 = DateTime.Now.Millisecond;
            Console.WriteLine("\n\tВремя выполнения: " + (time2 - time1));
        }

        private static int Reverse(int n)
        {
            var reverseValue = n%10;
            while ((n /= 10) != 0)
            {
                reverseValue = reverseValue*10+n%10;

            }

            return reverseValue;
        }

        private static void Ex4_4(int result = 0, int i = 10)
        {
            if (i==100)
            {
                Console.WriteLine("\tРезультат 4 задания: " + result);
            }
            else
            {
                result += i;
                Ex4_4(result,i+1);
            }
            
        }
    }
}