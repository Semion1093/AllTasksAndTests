using System;
using System.Collections.Generic;
using System.Text;

namespace AllTasks
{
    public class HomeWork_3
    {
        public static int CalculateNumbers(int a, int b)
        {
            if (a > b)
                return (a + b);
            else if (a == b)
                return (a * b);
            else
                return (a - b);
        }

        public static int GetQuarterOfCoordinatePlane(int a, int b)
        {
            if (a == 0 || b == 0)
                throw new ArgumentException("Одна из точек лежит на оси координат!");
            if (a == 0 && b == 0)
                throw new ArgumentException("Обе точки равны 0!");

            if (a > 0 && b > 0)
                return 1;
            else if (a > 0 && b < 0)
                return 2;
            else if (a < 0 && b < 0)
                return 3;
            else
                return 4;
        }

        public static double [] GetAscendingOrder(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                return new double[] { a, Math.Min(b, c), Math.Max(b, c) };
            }
            if (b < a && b < c)
            {
                return new double[] { b, Math.Min(a, c), Math.Max(a, c) };
            }
            return new double[] { c, Math.Min(a, b), Math.Max(a, b) };
        }

        public static double[] GetSolutionOfQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("Коэффициент А в квадратном уравнении не может быть равен 0!");

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
                return new double[] { };

            if (D == 0)
            {
                return new double[] { -b / 2 * a };
            }
            else
            {
                return new double[] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) };
            }
        }

        public static string GetNameOfNumber(int a)
        {
            if (a < 0)
                throw new ArgumentException("Введенное число отрицательное!");
            if (InputOutputHelp.GetLengthNumber(a) < 2)
                throw new ArgumentException("Введенное число не является двузначным!");
            if (InputOutputHelp.GetLengthNumber(a) > 2)
                throw new ArgumentException("Введенное число не является двузначным!");


            if (a == 10) return "Десять";
            if (a == 11) return "Одиннадцать"; 
            if (a == 12) return "Двенадцать"; 
            if (a == 13) return "Тринадцать"; 
            if (a == 14) return "Четырнадцать"; 
            if (a == 15) return "Пятнадцать";
            if (a == 16) return "Шестнадцать"; 
            if (a == 17) return "Семнадцать"; 
            if (a == 18) return "Восемнадцать"; 
            if (a == 19) return "Девятнадцать";

                int d1 = a / 10;
                int d2 = a % 10;

                string s1 = "";
                string s2 = "";

                switch (d1)
                {
                    case 2: s1 = "Двадцать "; break;
                    case 3: s1 = "Тридцать "; break;
                    case 4: s1 = "Сорок "; break;
                    case 5: s1 = "Пятьдесят "; break;
                    case 6: s1 = "Шестьдесят "; break;
                    case 7: s1 = "Семдесят "; break;
                    case 8: s1 = "Восемдесят "; break;
                    case 9: s1 = "Девяносто "; break;
                }

                switch (d2)
                {
                    case 1: s2 = "один"; break;
                    case 2: s2 = "два"; break;
                    case 3: s2 = "три"; break;
                    case 4: s2 = "четыре"; break;
                    case 5: s2 = "пять"; break;
                    case 6: s2 = "шесть"; break;
                    case 7: s2 = "семь"; break;
                    case 8: s2 = "восемь"; break;
                    case 9: s2 = "девять"; break;
                }
                return $"{s1}{s2}";
            }

        public static bool GetIsTriangleExist(double a, double b, double c)
        {
            if (a < 0)
                throw new ArgumentException("Введенное число не может быть отрицательным!");
            if (b < 0)
                throw new ArgumentException("Введенное число не может быть отрицательным!");
            if (c < 0)
                throw new ArgumentException("Введенное число не может быть отрицательным!");
            if (a == 0 || b == 0 || c == 0)
                throw new ArgumentException("Введенное число не может быть равно 0!");

            if ((a + b) < c)
                    return false;
                else if ((a + c) < b)
                    return false;
                else if ((b + c) < a)
                    return false;
                else 
                   return true;
        }
    }
}



