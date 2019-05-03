using System;
using System.Diagnostics;

namespace FifthTaskOfTheSecondOption
{
    internal class Program
    {
        private static readonly Random Random = new Random();

        public static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            var matrix = GetMatrix(m, n);
            PrintMatrix(matrix);
            AntialiasingMatrix(matrix);
            PrintMatrix(matrix);
        }

        private static double[,] GetMatrix(int m, int n)
        {
            double[,] matrix = new double[m, n];
            FillMatrix(matrix);
            return matrix;
        }

        private static void FillMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Random.NextDouble();
                }
            }
        }

        private static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0:F}\t",matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void AntialiasingMatrix(double[,] matrix)
        {
            int qtyColumns = matrix.GetLength(1);
            int qtyrRows = matrix.GetLength(0);

            for (int i = 0; i < qtyrRows; i++)
            {
                for (int j = 0; j < qtyColumns; j++)
                {
                    matrix[i, j] = GetAverage(matrix,i,j);
                }
            }

        }

        private static double GetAverage(double[,] matrix, int i, int j)
        {
            double sum = 0;
            int qty = 0;

            int fromi = Math.Max(0, i - 1), toi = Math.Min(matrix.GetLength(0) - 1, i + 1);
            int fromj = Math.Max(0, j - 1), toj = Math.Min(matrix.GetLength(1) - 1, j + 1);

            for (int k = fromi; k < toi+1; k++)
            {
                for (int l = fromj; l < toj+1; l++)
                {
                        sum += matrix[k, l];
                        qty++;
                }
            }
            return (sum - matrix[i, j])/qty;
        }
    }
}

/*for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == columns - 1)
                    {
                        if (j == 0)
                        {
                            if (i == 0)
                            {
                                //Левый верхний угол 
                                matrix[i, j] = Math.Round((matrix[i + 1, j] +
                                                           matrix[i + 1, j + 1] +
                                                           matrix[i, j + 1]) / 3, 2);
                            }
                            else if (i == rows - 1)
                            {
                                //Левый нижний угол
                                matrix[i, j] = Math.Round((matrix[i - 1, j] +
                                                           matrix[i - 1, j + 1] +
                                                           matrix[i, j + 1]) / 3, 2);
                            }
                            else
                            {
                                // все элементы левой колонки, кроме угловых
                                matrix[i, j] = Math.Round((matrix[i - 1, j] +
                                                           matrix[i - 1, j + 1] +
                                                           matrix[i, j + 1] +
                                                           matrix[i + 1, j + 1] +
                                                           matrix[i + 1, j]) / 5, 2);
                            }
                        }

                        if (j == columns - 1)
                        {
                            if (i == 0)
                            {
                                //Правый верхний угол
                                matrix[i, j] = Math.Round((matrix[i, j - 1] +
                                                           matrix[i + 1, j - 1] +
                                                           matrix[i + 1, j]) / 3, 2);
                            }
                            else if (i == rows - 1)
                            {
                                //Правый нижний угол
                                matrix[i, j] = Math.Round((matrix[i - 1, j] +
                                                           matrix[i - 1, j - 1] +
                                                           matrix[i, j - 1]) / 3, 2);
                            }
                            else
                            {
                                // все элементы правой колонки, кроме угловых
                                matrix[i, j] = Math.Round((matrix[i - 1, j] +
                                                           matrix[i - 1, j - 1] +
                                                           matrix[i, j - 1] +
                                                           matrix[i + 1, j - 1] +
                                                           matrix[i + 1, j]) / 5, 2);
                            }
                        }

                        if (j != 0 && j != columns - 1 && i == 0)
                        {
                            //верхняя линия, кроме углов
                            matrix[i, j] = Math.Round((matrix[i, j + 1] +
                                                       matrix[i + 1, j + 1] +
                                                       matrix[i + 1, j] +
                                                       matrix[i + 1, j - 1] +
                                                       matrix[i, j - 1]) / 5, 2);
                        }

                        if (j != 0 && j != columns - 1 && i == rows - 1)
                        {
                            //Нижняя линия
                            matrix[i, j] = Math.Round((matrix[i, j + 1] +
                                                       matrix[i - 1, j + 1] +
                                                       matrix[i - 1, j] +
                                                       matrix[i - 1, j - 1] +
                                                       matrix[i, j - 1]) / 5, 2);
                        }
                    }
                    else
                    {
                        //Все остальные элементы  
                        matrix[i, j] = Math.Round((matrix[i, j + 1] +
                                                   matrix[i - 1, j + 1] +
                                                   matrix[i - 1, j] +
                                                   matrix[i - 1, j - 1] +
                                                   matrix[i + 1, j + 1] +
                                                   matrix[i + 1, j] +
                                                   matrix[i + 1, j - 1] +
                                                   matrix[i, j - 1]) / 8, 2);
                    }
                }
            }*/