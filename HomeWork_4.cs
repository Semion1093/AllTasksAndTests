using System;
using System.Collections.Generic;
using System.Text;

namespace AllTasks
{
    public class HomeWork_4
    {
        public static List<int> GetNumbersDividedOnA(int a)
        {
            if (a > 1000)
                throw new ArgumentException("Введенное число больше 1000!");
            if (a == 0)
                throw new ArgumentException("На 0 делить нельзя!");
            if (a < 0)
                throw new ArgumentException("Введенное число меньше 0!");

            List<int> res = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    res.Add(i);
                }
            }
            return res;
        }
        public static int NumbersWhoseSquareIsLessThanA(int a)
        {
            if (a == 0)
                throw new ArgumentException("На 0 делить нельзя!");

            int count = 0;
            for (int i = 0; i < a; i++)
            {
                if ((Math.Pow(i, 2)) < a)
                    count++;
            }
            return count;
        }
        public static int GetGreatestDivisor(int a)
        {
            if (a == 0)
                throw new ArgumentException("На 0 делить нельзя!");

            if (a == 1) return 1;

            int div;
            for (div = a / 2; div >= 1; div--)
            {
               if (a % div == 0)
                {
                    break;
                }
            }
            return div;
        }
        public static int GetSumOfNumbersWhoseDivideOnSeven(int a, int b)
        {
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);

            int sum = 0;
            for (int i = min; i <= max; i++)
                if (i % 7 == 0)
                {
                    sum += i;
                }

            return sum;
        }
        public static int GetGreatestDivisorUsingEuclidAlgorithm(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }
        public static int FindNumberUsingHalfDivisionMethod(int a)
        {
            if (a < 0)
                throw new ArgumentException("Введенное число меньше 0!");
            if (a == 0)
                throw new ArgumentException("Введенное число равно 0!");
            int l = 0, r = a, m = -1;
            while (l != m)
            {
                m = (l + r) / 2;
                if (Math.Pow(m, 3) == a) break;

                if (Math.Pow(m, 3) > a)
                    r = m;
                else
                    l = m;
            }
            return m;
        }
        public static int GetSummaryOfOddDigitsOfNumber(int a)
        {
            if (a < 0)
                throw new ArgumentException("Введенное число меньше 0!");
            if (a == 0)
                throw new ArgumentException("Введенное число равно 0!");

            int cnt = 0;
            while (a > 0)
            {
                if ((a % 10) % 2 == 1)
                    cnt++;
                a /= 10;
            }
            return cnt;
        }
        public static int GetMirrorNumber(int a)
        {
            if (a < 0)
                throw new ArgumentException("Введенное число меньше 0!");

            int sum = 0;
            for (; a > 0; a /= 10)
            {
                sum *= 10;
                sum += a % 10;
            }
            return sum;
        }
        public static List<int> GetNumbersWhichSumOfEvenMoreThanSumOfOdd(int a)
        {
            if (a < 0)
                throw new ArgumentException("Введенное число меньше 0!");
            if (a == 0)
                throw new ArgumentException("Введенное число равно 0!");

            List<int> res = new List<int>();

            for (int i = 10; i <= a; i++)
            {
                int even_sum = 0;
                int odd_sum = 0;

                int copy = i;
                while (copy > 0)
                {
                    int d = copy % 10;
                    if (d % 2 == 0) even_sum += d;
                    else odd_sum += d;
                    copy /= 10;
                }

                if (even_sum > odd_sum)
                    res.Add(i);
            }
            return res;
        }
        public static bool AreIdenticalDigitsInTwoNumbers(int a, int b)
        {
            bool the_end = false;
            while (a > 0)
            {
                int d1 = a % 10;
                int ch2_copy = b;
                while (ch2_copy > 0)
                {
                    int d2 = ch2_copy % 10;
                    if (d1 == d2)
                    {
                        return true;
                    }
                    ch2_copy /= 10;
                }
                if (the_end) break;
                a /= 10;
            }
               return false;
        }
    }
}
