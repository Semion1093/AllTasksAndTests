using System;

namespace AllTasks
{
    public class HomeWork_1
    {
        public static string GetHelloByeString(int a, double b)
        {
            double c = a + b;

            return $"привет, {a}!\n{a} + {b} = {c}\nпока, {b}...";
        }

        public static double DecisideTask(int a, int b)
        {
            if (a == b)
                throw new ArgumentException("А не может быть равно В!");
            if (a == 0 && b == 0)
                throw new ArgumentException("А и В не могут быть равны нулю!");

            return (5 * a + Math.Pow(b, 4)) / (b - a);

        }

        public static string ChangeStrings(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2))
                throw new ArgumentException("Введена пустая строка!");
            if (string.IsNullOrWhiteSpace(s1) && string.IsNullOrWhiteSpace(s2))
                throw new ArgumentException("Вы ничего не ввели!");

            string temp;
            temp = s1;
            s1 = s2;
            s2 = temp;
            return ($"{s1}{s2}");
        }

        public static double SolveLinearEquation(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
                throw new ArgumentException("Аргументы не могут быть равны нулю!");
            return (c - b) / a;
        }
    }
}
