using System;
using System.Collections.Generic;

namespace AllTasks
{
    public class HomeWork_6
    {
        public static int[,] ChangeSignToTheOpposite(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1)
                        matrix[i, j] = matrix[i, j] * (-1);
                }
            }
            return matrix;
        }

        public static int[,] GetMultiplicationTable()
        {
            int[,] matrix = new int[9, 9];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                }
            }
            return matrix;
        }

        public static int[,] GetChessBoard()
        {
            int[,] matrix = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 1 && j % 2 == 0)
                        matrix[i, j] = 0;
                    else if (i % 2 == 0 && j % 2 == 1)
                        matrix[i, j] = 0;
                    else matrix[i, j] = 1;
                }
            }
            return matrix;
        }

        public static bool IsSeatingArrangementsTrue(int[,] matrix)
        {
            bool is_rule = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == 1 && matrix[i, j + 1] == 1)
                    {
                        is_rule = false;
                        break;
                    }
                }
                if (!is_rule) break;
            }
            if (is_rule) return true;

            else return false;
        }

        public static (List<decimal>, List<decimal>, decimal, decimal) GetResulstOFShops(decimal[,] amounts)
        {
            decimal[] sum_by_months = new decimal[6] { 0, 0, 0, 0, 0, 0 };
            List<decimal> res_sum_by_shop = new List<decimal>();

            decimal amin = amounts[0, 0];
            decimal amax = amounts[0, 0];

            for (int i = 0; i < amounts.GetLength(0); i++)
            {
                decimal sum_by_shop = 0;

                for (int j = 0; j < amounts.GetLength(1); j++)
                {
                    sum_by_shop += amounts[i, j];
                    sum_by_months[j] += amounts[i, j];

                    if (amounts[i, j] < amin) amin = amounts[i, j];
                    if (amounts[i, j] > amax) amax = amounts[i, j];
                }
                res_sum_by_shop.Add(sum_by_shop);
            }

            List<decimal> res_sum_by_month = new List<decimal>();

            for (int i = 0; i < sum_by_months.Length; i++)
            {
                res_sum_by_month.Add(sum_by_months[i] / amounts.GetLength(0));
            }
            return (res_sum_by_shop, res_sum_by_month, amin, amax);
        }

        public static int GetLargestNeighbours(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int sosedi = (i > 0 ? matrix[i - 1, j] : 0)
                        + (i < matrix.GetLength(0) - 1 ? matrix[i + 1, j] : 0)
                        + (j > 0 ? matrix[i, j - 1] : 0)
                        + (j < matrix.GetLength(1) - 1 ? matrix[i, j + 1] : 0);
                    if (matrix[i, j] > sosedi)
                        count++;
                }
            }
            return count;
        }

        public static int[,] GetFilInCharArray()
        {
            int[,] matrix = new int[7, 7];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i <= j && i <= matrix.GetLength(0) - j - 1)
                         || (i >= j && i >= matrix.GetLength(0) - j - 1) ? '1' : '0';
                }
            }
            return matrix;
        }

        public static int[,] GetMatrixMultiplication(int[,] a, int[,] b)
        {
            int[,] matrix_mult = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        matrix_mult[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return matrix_mult;
        }
    }
}



