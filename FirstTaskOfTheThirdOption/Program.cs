using System;

namespace FirstTaskOfTheThirdOption
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = GetArray();
            Console.WriteLine("\nМассив создан!");
            
            PrintArray(array);
            Console.WriteLine(GetAmtNegativeNum(array));
            Console.WriteLine(GetSumEvenNumbers(array));
            Console.WriteLine(GetIndexMaxPositiveNumber(array));
        }

        private static int[] GetArray()
        {
            int[] array = new int[15];
            return FillArray(array);
        }

        private static int[] FillArray(int[] arg)                                                                       
        {
            var random = new Random();
            for (int i = 0; i < 15; i++)
            {
                arg[i] = random.Next(-150, 151);
            }

            return arg;
        }

            private static int GetAmtNegativeNum(int[] arg)
        {
            int amtNegativeNum = 0;

            foreach (var item in arg)
            {
                if (item < 0) amtNegativeNum++;
            }

            return amtNegativeNum;
        }

        private static int GetSumEvenNumbers(int[] arg)
        {
            var sumEvenNumbers = 0;
            foreach (var item in arg)
            {
                if (item % 2 == 0) sumEvenNumbers += item;
            }

            return sumEvenNumbers;
        }

        private static int GetIndexMaxPositiveNumber(int[] arg)
        {
            var indexMaxPositiveNum = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i]>arg[indexMaxPositiveNum])
                {
                    indexMaxPositiveNum = i;
                }
            }
    
            return indexMaxPositiveNum;
        }

        private static void PrintArray(int[] arg)
        {
            for (var i = 0; i < 15; i++)
                if (i % 2 == 0)
                    Console.Write("a[{0}]={1}  ", i, arg[i]);
        }
    }
}