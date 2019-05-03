using System;


// Проверено, сдано!


namespace Lab_2_v_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Дудка Леонид, Вариант 6:
             * 1-3;
             * 2-2;
             * 3-1;
             */
            Console.Write("Задание 1(3): ");
            Ex1_3();
            Console.Write("Задание 2(2): ");
            Ex2_2();
            Console.Write("Задание 3(1): ");
            Console.Write("введите натуральное число n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Ex3_1(n);
        }

        private static void Ex1_3()
        {
            while (true)
            {
                Console.WriteLine("Введите значения: ");
                var x = InitDoubleValue('x');
                var a = InitDoubleValue('a');
                var b = InitDoubleValue('b');
                var c = InitDoubleValue('c');
                double? f;
                if (c < 0 && x != 0)
                {
                    Console.WriteLine("Вы пошли по ветке: f = -a * x * -c");
                    f = -a * x * -c;
                }
                else if (c > 0 && b == 0)
                {
                    Console.WriteLine("Вы пошли по ветке: f = (x - a) / -c");
                    f = (x - a) / -c;
                }
                else if (c - a != 0)
                {
                    Console.WriteLine("Вы пошли по ветке: f = b * x / (c - a)");
                    f = b * x / (c - a);
                }
                else
                {
                    Console.WriteLine("Вы облажались");
                    f = null;
                }

                if (f != null)
                {
                    Console.WriteLine("\tРезультат 1 задания: " + f);
                }
                else
                {
                    Console.Write("\tРезультат 1 задания: не существует, повторить? (Y/...) ");
                    var choice = Console.ReadLine();
                    if (choice == "Y") continue;
                }

                break;
            }
        }

        private static double InitDoubleValue(char sim)
        {
            var simInitValue = sim;

            try
            {
                Console.Write("\t\t\t\t" + sim + " = ");
                var xDouble = Convert.ToDouble(Console.ReadLine());
                return xDouble;
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный формат, введите еще раз!");

                return InitDoubleValue(simInitValue);
            }
        }

        private static void Ex2_2()
        {
            Console.Write("Введите натуральное число n: ");
            var n = Convert.ToDouble(Console.ReadLine()) * 2;
            var k = 1;
            var sum = 0.0;

            for (var i = 0; i < n; i++)
            {
                if (k % 4 == 0)
                {
                    k++;
                    continue;
                }

                sum += Math.Pow(-1, k) / (2 * k + 1);
                //Console.WriteLine("{0}) sum = {1}",k, sum);
                k++;
            }

            Console.WriteLine("\tРезультат 2 задания: " + sum);
        }

        private static void Ex3_1(int n = 5)
        {
            var rezult = 0.0;
            var del = 1;
            for (var i = 1; i < n + 1; i++)
            {
                rezult += 1.0 / (i * del);
                del *= i;
                Console.WriteLine(rezult);
            }

            Console.WriteLine("\tРезультат 3 задания: " + rezult);
        }
    }
}