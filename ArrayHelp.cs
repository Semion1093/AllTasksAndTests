using System;
using System.Collections.Generic;
using System.Text;

namespace AllTasks
{
    static class ArrayHelp
    {
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

        }

        public static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0:f2}\t", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static int[] GenerateArray(int size, int min, int max)
        {
            int[] res = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rnd.Next(min, max + 1);
            }
            return res;
        }

        public static double[] GenerateArray(int size, double min, double max)
        {
            double[] res = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rnd.NextDouble() * (max - min) + min;
            }
            return res;
        }

        public static int[,] GenerateArray(int rows, int cols, int min, int max)
        {
            int[,] matrix = new int[rows, cols];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(min, max + 1);
                }
            }
            return matrix;
        }

        public static double[,] GenerateArray(int rows, int cols, double min, double max)
        {
            double[,] matrix = new double[rows, cols];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.NextDouble() * (max - min) + min;
                }
            }
            return matrix;
        }
    }
}
