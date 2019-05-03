using System;

namespace ThirdTaskOfTheFirstOption
{
    internal class Program
    {
        private static readonly Random Random = new Random();

        public static void Main(string[] args)
        {
            int[] arrayFirst = GetArray(3);
            int[] arraySecond = GetArray(3);

            PrintArray(arrayFirst);
            PrintArray(arraySecond);

            int[] thirdArray = MergeArrays(arrayFirst, arraySecond);
            PrintArray(thirdArray);
        }

        public static int[] GetArray(int length)
        {
            int[] array = new int[length];
            FillArray(array);
            SortArray(array);
            return array;
        }

        private static void FillArray(int[] arg)
        {
            for (var j = 0; j < 3; j++)
            {
                arg[j] = Random.Next(1, 10);
            }
        }

        private static void SortArray(int[] arg)
        {
            int tmp;
            foreach (var unused in arg)
            {
                for (int i = 0; i < arg.Length - 1; i++)
                {
                    if (arg[i] > arg[i + 1])
                    {
                        tmp = arg[i];
                        arg[i] = arg[i + 1];
                        arg[i + 1] = tmp;
                    }
                }
            }
        }

        private static void PrintArray(int[] arg)
        {
            foreach (var item in arg)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        private static int[] MergeArrays(int[] arrayFirst, int[] arraySecond)
        {
            int[] mixArray = new int[arrayFirst.Length + arraySecond.Length];

            int pos = 0, i =0, j = 0;
            while (i < arrayFirst.Length && j < arraySecond.Length)
            {
                mixArray[pos++] = arrayFirst[i] < arraySecond[j] ? arrayFirst[i++] : arraySecond[j++];
            }

            while ( i < arrayFirst.Length)
            {
                mixArray[pos++] = arrayFirst[i++];
            }
            while ( j < arraySecond.Length)
            {
                mixArray[pos++] = arraySecond[j++];
            }

            return mixArray;
        }
    }
}


/*int pos = 0;
            int a = 0;
            int b = 0;
            for (; a < arrayFirst.Length && b < arraySecond.Length;)
            {
                if (arrayFirst[a] == arraySecond[b])
                {
                    mixArray[pos++] = arrayFirst[a++];
                    mixArray[pos++] = arraySecond[b++];
                }
                else if (arrayFirst[a] < arraySecond[b])
                {
                    mixArray[pos++] = arrayFirst[a++];
                }
                else
                {
                    mixArray[pos++] = arraySecond[b++];
                }
            }

            if (a == arrayFirst.Length)
            {
                for (; b < arraySecond.Length;)
                {
                    mixArray[pos++] = arraySecond[b++];
                }
            }
            else
            {
                for (; a < arrayFirst.Length;)
                {
                    mixArray[pos++] = arrayFirst[a++];
                }
            }*/