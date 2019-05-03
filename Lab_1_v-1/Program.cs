using System;


// Проверено, сдано!


namespace Lab_1_v_1
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
             * 4-1.
             */
            Console.Write("Задание 1(3): ");
            Ex1_3();
            Console.Write("Задание 2(2): ");
            Ex2_2();
            Console.Write("Задание 3(1): ");
            Console.WriteLine("Введите 8 чисел:");
            var m = DataInput('m');
            var n = DataInput('n');
            var p = DataInput('p');
            var a = DataInput('a');
            var b = DataInput('b');
            var c = DataInput('c');
            var d = DataInput('d');
            var e = DataInput('e');
            Ex3_1(m, n, p, a, b, c, d, e);
            Console.Write("Задание 4(1): ");
            Ex4_1();
        }

        private static void Ex1_3()
        {
            Console.Write("Введите число X: ");
            var x = Convert.ToInt32(Console.ReadLine());
            var square = x * x;
            var degreeFourth = square * square;
            var degreeSixth = degreeFourth * square;
            var degreeSeventh = degreeSixth * x;
            Console.WriteLine("\tРезультат 1 задания: " + degreeSeventh);
        }

        private static void Ex2_2()
        {
            Console.Write("Ввекдите 3-х значное число: ");
            var x = Convert.ToInt32(Console.ReadLine());

            var numFirst = x / 100 % 10;
            var numSecond = x / 10 % 10;
            var numThird = x % 10;

            Console.WriteLine("\tРезультат 2 задания: " + (numFirst + numSecond + numThird));
        }

        private static void Ex3_1(int m, int n, int p, int a, int b, int c, int d, int e)
        {
            var stepFirst = 527 * a / Math.Pow(b, 2 * p);
            var stepSecond = (123 + stepFirst) * (123 - stepFirst) /
                             Math.Pow(856 + Math.Pow(c, n) * Math.Pow(d, m), 1.0 / 3.0) * (e - Math.Log10(6));
            const int time = 7 + 0 + 12 + 20 + 21 + 65;
            Console.WriteLine("\tРезультат 3 задания: " + stepSecond + "\n\tВремя в ус: " + time);
        }

        private static int DataInput(char sim)
        {
            Console.Write("\t\t\t\t" + sim + " = ");
            var x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        private static void Ex4_1()
        {
            const double marsDistanceKm = 55.75; // млн. км
            Console.WriteLine("Минимальное расстояние от Земли до Марса = " + marsDistanceKm + " млн. км");
            var marsDistanceM = marsDistanceKm * Math.Pow(10, 9); // в метры
            var marsDistanceArshin = marsDistanceM * 0.7112 / 1000000; // в аршинах
            Console.WriteLine("\tРезультат 4 задания: " + marsDistanceArshin + " млн. аршин");
        }
    }
}