using System;

namespace AllTasks
{
    public class HomeWork_5
    {
        public static (int, int) GetSummaryOfEvenAndOddElementsInArray(int[] array)
        { 
            int cnt_even = 0;
            int cnt_odd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    cnt_even++;
                else
                    cnt_odd++;
            }
            return (cnt_even, cnt_odd);
        }

        public static int[] ReplaceEveryThirdElementSumOfTwoPrevious(int[] array)
        {
            int[] copy = array;

            for (int i = 2; i < copy.Length; i += 3)
            {
                copy[i] = copy[i - 1] + copy[i - 2];
            }
            return copy;
        }

        public static int[] MergeTwoArraysIntoOne(int[] array1, int[] array2)
        {
            int[] array_sum = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array_sum[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array_sum[array1.Length + i] = array2[i];
            }
            return array_sum;
        }

        public static int[] SwapFirstAndSecondHalfOfArray(int[] array)
        {
            int shift = array.Length % 2 != 0 ? 1 : 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[i + array.Length / 2 + shift];
                array[i + array.Length / 2 + shift] = tmp;
            }
            return array;
        }
        

        public static int[] ShiftArray(int[] array)
        {
            int[] copy = array;
            for (int j = 1; j <= 3; j++)
            {
                int last = array[array.Length - 1];

                for (int i = array.Length - 1; i >= 1; i--)
                {
                    array[i] = array[i - 1];
                }
                array[0] = last;
            }
            return copy;
        }

        public static int[] ConvertPositionsOfEvenElementsToOdd(int[] array)
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                int tmp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }

        public static (int, int) GetMinimumModuloElementAndSummaryOfElementsAfterZero(int[] array)
        {
            int sum = 0;
            bool is_zero = false;
            int max_pos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) is_zero = true;

                if (is_zero) sum += array[i];

                if (Math.Abs(array[i]) > Math.Abs(array[max_pos]))
                    max_pos = i;
            }
            return (max_pos, sum);
        }

        public static int[] SortInertionAlgorithm(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            return array;
        }

        public static int[] SortSelectionAlgorithm(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            return array;
        }

    }
}

