using System;
using System.Text;

namespace Lab_4_v_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            /*/*
             * Дудка Леонид, Вариант 6:
             * 1-3;
             * 2-3;
             * 3-1;
             * 4-2;
             * 5-2;
             * 6-1;
             * 7-1;
             * 8-2;
             #1#
            Console.WriteLine("Задание 1(3): ");
            Console.ReadKey();
            Ex1_3();


            Console.WriteLine("\nЗадание 2(3): ");
            Console.ReadKey();
            Ex2_3();


            Console.WriteLine("\nЗадание 3(1): ");
            Console.ReadKey();
            Ex3_1();


            Console.WriteLine("\nЗадание 4(2): ");
            Console.ReadKey();
            Ex4_2();


            Console.WriteLine("\nЗадание 5(2): ");
            Console.ReadKey();
            Ex5_2();


            Console.WriteLine("\nЗадание 6(1): ");
            Console.ReadKey();
            Ex6_1();


            Console.WriteLine("\nЗадание 7(1): ");
            Console.ReadKey();
            Ex7_1();


            Console.WriteLine("\nЗадание 8(2): ");
            Console.ReadKey();
            Ex8_2();*/
            
            
        }

        private static void Ex1_3()
        {
            var massArrayInt = new int[15];
            Console.Write("Создание массива: ");

            var random = new Random();
            for (var i = 0; i < 15; i++)
            {
                massArrayInt[i] = random.Next(-150, 151);
                Console.Write(i + 1 + ")_" + massArrayInt[i] + " ");
            }

            Console.WriteLine("\nМассив создан!");

            var negativeNumber = 0;
            var sumIntValueArrayMassPositive = 0;
            var maxIntPositiveNumber = 0;
            var maxIndexPositiveNumber = 0;

            foreach (var valueMassArrayInt in massArrayInt)
            {
                if (valueMassArrayInt < 0) negativeNumber++;

                if (valueMassArrayInt % 2 == 0) sumIntValueArrayMassPositive += valueMassArrayInt;

                if (valueMassArrayInt > maxIntPositiveNumber)
                {
                    maxIntPositiveNumber = valueMassArrayInt;
                    maxIndexPositiveNumber = Array.IndexOf(massArrayInt, valueMassArrayInt);
                }
            }

            Console.Write("\tРезультат 1 задания: количество отрицательных чисел: " + negativeNumber +
                          "\n\t\t\t\tcумма четных чисел: " + sumIntValueArrayMassPositive +
                          "\n\t\t\t\tномер максимального положительного числа: " + (maxIndexPositiveNumber + 1) +
                          "\n\t\t\t\tвывода элементов с четными номерами по формату: ");
            for (var i = 0; i < 15; i++)
                if (i % 2 == 0)
                    Console.Write("a[{0}]={1}  ", i, massArrayInt[i]);
        }

        private static void Ex2_3()
        {
            var n = Instruments.ReedIntValue("Введите число элементов массива: ");
            var random = new Random();
            var arrayMass = new int[n];
            for (var i = 0; i < n; i++)
            {
                arrayMass[i] = random.Next(0, 10);
                Console.Write(arrayMass[i] + " ");
            }

            Console.WriteLine();
            var k = Instruments.ReedIntValue("Индекст элемента, который нужно удалить: ");

            var arrayMassNew = new int[arrayMass.Length - 1];
            Array.Copy(arrayMass, 0, arrayMassNew, 0, k);
            Array.Copy(arrayMass, k + 1, arrayMassNew, k, arrayMass.Length - k - 1);
            Console.Write("\tРезультат 2 задания: ");
            foreach (var item in arrayMassNew) Console.Write(item + " ");
        }

        private static void Ex3_1()
        {
            var arrayMassFirst = new int[3];
            var random = new Random();
            Console.Write("Первый массив: ");
            for (var i = 0; i < 3; i++)
            {
                arrayMassFirst[i] = random.Next(1, 10);
                Console.Write(arrayMassFirst[i] + " ");
            }

            Array.Sort(arrayMassFirst);
            Console.WriteLine();


            var arrayMassSecond = new int[3];
            Console.Write("Второй массив: ");
            for (var i = 0; i < 3; i++)
            {
                arrayMassSecond[i] = random.Next(1, 10);
                Console.Write(arrayMassSecond[i] + " ");
            }

            Array.Sort(arrayMassSecond);
            Console.WriteLine();


            var arrayMassAll = new int[arrayMassFirst.Length + arrayMassSecond.Length];
            arrayMassFirst.CopyTo(arrayMassAll, 0);
            arrayMassSecond.CopyTo(arrayMassAll, arrayMassFirst.Length);
            Array.Sort(arrayMassAll);
            Console.Write("Совместный массив: ");
            foreach (var item in arrayMassAll) Console.Write(item + " ");

            Console.WriteLine();
        }

        private static void Ex4_2()
        {
            var m = Instruments.ReedIntValue("Введите параметр М: ");
            var n = Instruments.ReedIntValue("Введите параметр N: ");
            var massArray = new int[m, n];
            var random = new Random();
            for (var y = 0; y < m; y++)
            {
                for (var x = 0; x < n; x++)
                {
                    massArray[y, x] = random.Next(1, 10);
                    Console.Write(massArray[y, x] + " ");
                }

                Console.WriteLine();
            }

            var maxValue = 0;

            for (var x = 0; x < n; x++)
            {
                for (var y = 0; y < m; y++)
                    if (maxValue < massArray[y, x])
                        maxValue = massArray[y, x];
                Console.WriteLine("\tМаксимальное значение в {0} строчке: {1}", x + 1, maxValue);
                maxValue = 0;
            }

            var sumValue = 0;
            var i = 0;
            foreach (var itemMass in massArray)
            {
                if (itemMass % 2 != 0) continue;
                sumValue += itemMass;
                i++;
            }

            Console.Write("\tРезультат 4 задания: ");
            Console.Write("среднее значение среди всех" +
                          " нечетных элементов: " + Math.Round((double) sumValue / i, 3));
        }

        private static void Ex5_2()
        {
            var m = Instruments.ReedIntValue("Введите параметр М: ");
            var n = Instruments.ReedIntValue("Введите параметр N: ");
            var massArray = new double[n, m];
            var random = new Random();
            Console.WriteLine("Исходная таблица: ");
            for (var iY = 0; iY < n; iY++)
            {
                for (var iX = 0; iX < m; iX++)
                {
                    massArray[iY, iX] = Math.Round((double) random.Next(1, 10) / random.Next(1, 10), 1);
                    Console.Write(" " + massArray[iY, iX] + "\t");
                }

                Console.WriteLine();
            }


            for (var iY = 0; iY < n; iY++)
            for (var iX = 0; iX < m; iX++)
            {
                if (iX + 1 > m) massArray[iY, iX + 1] = Math.Round((massArray[iY, iX] + massArray[iY, iX + 1]) / 2, 1);
                if (iX - 1 > 0) massArray[iY, iX - 1] = Math.Round((massArray[iY, iX] + massArray[iY, iX - 1]) / 2, 1);
                if (iY + 1 > n) massArray[iY + 1, iX] = Math.Round((massArray[iY, iX] + massArray[iY + 1, iX]) / 2, 1);
                if (iY - 1 > 0) massArray[iY - 1, iX] = Math.Round((massArray[iY, iX] + massArray[iY - 1, iX]) / 2, 1);
            }

            Console.Write("\tРезультат 5 задания: ");
            Console.WriteLine("\nОбработанная таблица: ");
            for (var iY = 0; iY < n; iY++)
            {
                for (var iX = 0; iX < m; iX++) Console.Write(" " + massArray[iY, iX] + "\t");
                Console.WriteLine();
            }
        }

        private static void Ex6_1()
        {
            Console.Write("Ведите строку: ");
            var wordValue = Console.ReadLine();
            wordValue += '.';
            var i = 0;
            foreach (var ch in wordValue)
                if (ch == ' ' || ch == '.')
                    i++;
            Console.Write("\tРезультат 6 задания: {0} ", i);
        }

        private static void Ex7_1()
        {
            var lineValue = Instruments.ReedIntValue("\tВведите длину строки: ");
            var text = "";
            var random = new Random();
            for (var i = 0; i < lineValue; i++)
            {
                var randValue = random.Next(1, 6);
                switch (randValue)
                {
                    case 1:
                        text += (char) random.Next(97, 105);
                        break;
                    case 2:
                        text += (char) random.Next(49, 56);
                        break;
                    case 3:
                        text += '?';
                        break;
                    case 4:
                        text += '!';
                        break;
                    case 5:
                        text += ';';
                        break;
                }
            }

            var newStringText = new StringBuilder(text, lineValue);

            for (var i = 0; i < newStringText.Length; i++)
                if (newStringText[i] == ';')
                    newStringText[i] = '_';
            Console.Write("\tРезультат 7 задания: " + newStringText);
        }

        private static void Ex8_2()
        {
            var random = new Random();
            var sumMin = 0;
            const int value1 = 3;
            const int value2 = 2;

            var array1 = Instruments.CreateArray(value2, value2, random, ref sumMin);
            var array2 = Instruments.CreateArray(value1, value2, random, ref sumMin);
            var array3 = Instruments.CreateArray(value2, value1, random, ref sumMin);

            Console.Write("\tРезультат 8 задания: " + sumMin);
        }
    }

    class TaskFirst
    {
        public static void MainTask()
        {
            Console.Write("Создание массива: ");
            var massMain = CreateMass();
            Console.WriteLine("\nМассив создан!");
            CalcNegativeNumber(massMain);
            CalcEvenNumbers(massMain);
            FindMaxPositiveNumber(massMain);
            PrintEvenNumber(massMain);
        }

        private static int[] CreateMass()
        {
            var massArrayInt = new int[15];
            var random = new Random();
            for (var i = 0; i < 15; i++)
            {
                massArrayInt[i] = random.Next(-150, 151);
                Console.Write(i + 1 + ")_" + massArrayInt[i] + " ");
            }
            return massArrayInt;
        }

        private static int CalcNegativeNumber(int[] massMain)
        {
            var negativeNumber = 0;
            foreach (var valueMassArrayInt in massMain)
            {
                if (valueMassArrayInt < 0) negativeNumber++; 
            }
            return negativeNumber;
        }

        private static int CalcEvenNumbers(int[] massMain)
        {
            var sumIntValueArrayMassPositive = 0;
            foreach (var valueMassArrayInt in massMain)
            {
                if (valueMassArrayInt % 2 == 0) sumIntValueArrayMassPositive += valueMassArrayInt;
            }
            return sumIntValueArrayMassPositive;
        }

        private static int FindMaxPositiveNumber(int[] massMain)
        {
            var maxIndexPositiveNumber = 0;
            foreach (var valueMassArrayInt in massMain)
            {
                maxIndexPositiveNumber = Array.IndexOf(massMain, valueMassArrayInt);
            }
            return maxIndexPositiveNumber;
        }

        private static void PrintEvenNumber(int[] massMain)
        {
            for (var i = 0; i < 15; i++)
                if (i % 2 == 0)
                    Console.Write("a[{0}]={1}  ", i, massMain[i]);
        }
    }

    class TaskSecond
    {
        public static void MainTask()
        {
            
        }
    }

    internal static class Instruments
    {
        public static int ReedIntValue(string s)
        {
            Console.Write(s);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int[,] CreateArray(int x, int y, Random r, ref int sumMin)
        {
            var massArrayInt = new int[y, x];
            int xMass;

            for (var i = 0; i < y; i++)
            {
                Console.Write("|");
                var minValue = 10;
                xMass = r.Next(0, x + 1);
                for (var j = 0; j < xMass; j++)
                {
                    massArrayInt[i, j] = r.Next(1, 10);
                    Console.Write(massArrayInt[i, j] + "  ");
                    if (minValue > massArrayInt[i, j]) minValue = massArrayInt[i, j];
                }

                if (minValue != 10) sumMin += minValue;
                Console.WriteLine();
            }

            return massArrayInt;
        }
    }
}