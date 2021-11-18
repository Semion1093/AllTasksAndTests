using System;
using System.Collections.Generic;
using System.Text;

namespace AllTasks
{
    class InputOutputHelp
    {
        public static int SaveInput(int min, int max, string message)
        {
            int num;
            do
            {
                Console.Write($"{message} [{min}-{max}]: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }
        public static double SaveInput(double min, double max, string message)
        {
            double num;
            do
            {
                Console.Write($"{message} [{min}-{max}]: ");
                num = Convert.ToDouble(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }
        public static (double, double) InputPoint(string message)
        {
            Console.WriteLine($"{message}");

            Random rnd = new Random();
            double x = rnd.NextDouble();
            double y = rnd.NextDouble();
            return (x, y);
        }
        public static void Line(int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }
        public static void LineStar(int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        public static int GetLengthNumber(int value)
        {
            int l = value.ToString().Length;
            if (value < 0)
            {
                l -= 1;
            }
            return l;
        }

    }
}
