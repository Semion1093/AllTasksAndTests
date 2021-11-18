using System;

namespace AllTasks
{
    public class HomeWork_2
    {

        public static int GetSumOfNumbers(int a)
        {
            if (InputOutputHelp.GetLengthNumber(a) < 3) 
                throw new ArgumentException("Введенное число не является трехзначным!");
            if (InputOutputHelp.GetLengthNumber(a) > 3)
                throw new ArgumentException("Введенное число не является трехзначным!");
            if (a == 0)
                throw new ArgumentException("Введенное число равно 0!");

            int x1 = Math.Abs(a) % 10;
            int x2 = (Math.Abs(a) / 10) % 10;
            int x3 = Math.Abs(a) / 100;

            return (x1 + x2 + x3);
        }

        public static bool GetResOfShot(double x, double y, double radius)
        {
            if (radius == 0)
                throw new ArgumentException("Радиус не может равняться 0!");
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным!");

            return Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2);
        }

        public static bool CompareNumbers(int a)
        {
            if (InputOutputHelp.GetLengthNumber(a) < 3)
                throw new ArgumentException("Введенное число не является трехзначным!");
            if (InputOutputHelp.GetLengthNumber(a) > 3)
                throw new ArgumentException("Введенное число не является трехзначным!");
            if (a == 0)
                throw new ArgumentException("Введенное число равно 0!");


            int a1 = Math.Abs(a) / 100;
            int a2 = (Math.Abs(a) / 10) % 10;
            int a3 = Math.Abs(a) % 10;

            return (a2 <= a1 & a2 > a3);
        }

        public static int ChangeNumbers(int a)
        {
            if (InputOutputHelp.GetLengthNumber(a) < 3)
                throw new ArgumentException("Введенное число не является трехзначным!");
            if (InputOutputHelp.GetLengthNumber(a) > 3)
                throw new ArgumentException("Введенное число не является трехзначным!");
            if (a == 0)
                throw new ArgumentException("Введенное число равно 0!");

            int a1 = Math.Abs(a) / 100;
            int a2 = (Math.Abs(a) / 10) % 10;
            int a3 = Math.Abs(a) % 10;

            int temp;
            temp = a1;
            a1 = a3;
            a3 = temp;

            return (a1 * 100) + (a2 * 10) + a3;
        }

        public static bool GetFractionalPartIsZeroOrNo(double a)
        {
            int number1 = (int)a;
            bool result = number1 == a;

            return result;
        }
    }
}
