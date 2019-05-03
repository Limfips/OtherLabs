using System;

namespace EighthTaskOfTheSecondOption
{
    internal class Program
    {
        private static readonly Random Random = new Random();
        public static void Main(string[] args)
        {
            
            var matrixFirst = GetMatrix(2, 2);
            var matrixSecond = GetMatrix(3, 2);
            var matrixThird = GetMatrix(2, 3);

            int[][,] jaggedArrays = {matrixFirst, matrixSecond, matrixThird};
            PrintJaggedArrays(jaggedArrays);
            
            Console.WriteLine(GetSumMinValues(jaggedArrays));
        }
        private static int[,] GetMatrix(int column, int row)
        {
            int[,] matrix = new int[column, row];  
            FillMatrix(matrix);
            return matrix;
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Random.Next(1, 10);
                }
            }  
        }
        private static int GetSumMinValues(int[][,] arrayOfMatrices)
        {
            int sumMinValues = 0;                                            
            foreach (var array in arrayOfMatrices)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int minRowValue = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (minRowValue == 0 || minRowValue > array[i,j])
                        {
                            minRowValue = array[i, j];
                        } 
                    }
                    sumMinValues += minRowValue;
                }
            }
            return sumMinValues;
        }
        private static void PrintJaggedArrays(int[][,] jaggedArrays)
        {
            foreach (var array in jaggedArrays)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i,j]+"  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("----------------");
            }
        }
    }
}