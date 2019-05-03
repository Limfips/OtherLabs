using System;

namespace FourthTaskOfTheSecondOption
{
    internal class Program
    {
        private static readonly Random Random = new Random();

        public static void Main(string[] args)
        {
            int columns = Convert.ToInt32(Console.ReadLine());
            int row = Convert.ToInt32(Console.ReadLine());

            var matrix = GetMatrix(columns, row);
            PrintMatrix(matrix);
            PrintMaxElements(matrix);
            Console.WriteLine(GetAverageValue(matrix));
        }

        private static int[,] GetMatrix(int columns, int row)
        {
            int[,] matrix = new int[columns, row];
            FillMatrix(matrix);
            return matrix;
        }

        private static void FillMatrix(int[,] arg)
        {
            for (int i = 0; i < arg.GetLength(0); i++)
            {
                for (int j = 0; j < arg.GetLength(1); j++)
                {
                    arg[i, j] = Random.Next(1, 10);
                }
            }
        }

        private static void PrintMatrix(int[,] arg)
        {
            for (int i = 0; i < arg.GetLength(0); i++)
            {
                for (int j = 0; j < arg.GetLength(1); j++)
                {
                    Console.Write(arg[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void PrintMaxElements(int[,] arg)
        {
            int[] maxElements = GetMaxElements(arg);
            Console.WriteLine("MaxElements");
            foreach (var element in maxElements)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine();
        }

        private static int[] GetMaxElements(int[,] arg)
        {
            int[] maxElements = new int[arg.GetLength(1)];
            int maxElement;
            for (int i = 0; i < arg.GetLength(1); i++)
            {
                maxElement = 0;
                for (int j = 0; j < arg.GetLength(0); j++)
                {
                    if (maxElement < arg[j, i])
                    {
                        maxElement = arg[j, i];
                    }
                }

                maxElements[i] = maxElement;
            }

            return maxElements;
        }

        private static int GetAverageValue(int[,] arg)
        {
            int average = 0;
            int quantity = 0;
            foreach (var itemMass in arg)
            {
                if (itemMass % 2 != 0)
                {
                    average += itemMass;
                    quantity++;
                }
            }

            return average / quantity;
        }
    }
}