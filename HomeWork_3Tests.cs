using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AllTasks.Tests
{
    public class HomeWork_3Tests
    {
        [TestCase(0, 1, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 1, -1)]
        [TestCase(1, -1, 0)]
        public void CalculateNumbersTest(int a, int b, int expected)
        {
            Assert.AreEqual(expected, HomeWork_3.CalculateNumbers(a, b));
        }

        [TestCase(4, 7, 1)]
        [TestCase(2, -9, 2)]
        [TestCase(-3, -8, 3)]
        [TestCase(-1, 5, 4)]
        public void GetQuarterOfCoordinatePlaneTest(int a, int b, int expected)
        {
            Assert.AreEqual(expected, HomeWork_3.GetQuarterOfCoordinatePlane(a, b));
        }

        [TestCase(8, 0)]
        [TestCase(0, 9)]
        [TestCase(0, 0)]
        public void GetQuarterOfCoordinatePlaneNegativeTest(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_3.GetQuarterOfCoordinatePlane(a, b));
        }

        [TestCase(0, 0, 0, new double[] { 0, 0, 0 })]
        [TestCase(1.0, 0.0, 0.1, new double[] { 0.0, 0.1, 1.0 })]
        [TestCase(-7.3, 0.2, 3.5, new double[] { -7.3, 0.2, 3.5 })]
        [TestCase(2.7, 0.0, 0.0, new double[] { 0.0, 0.0, 2.7 })]
        [TestCase(0.5, - 7.2, -7.2, new double[] { -7.2, -7.2, 0.5 })]
        public void GetAscendingOrderTest(double a, double b, double c, double[] expected)
        {
            Assert.AreEqual(expected, HomeWork_3.GetAscendingOrder(a, b, c));
        }

        [TestCase(3, -4, 2, new double[] { })]
        [TestCase(1, -4, -5, new double[] { 5, -1 })]
        [TestCase(-1, 7, 8, new double[] { -1, 8 })]
        [TestCase(2, 1, 1, new double[] { })]
        [TestCase(1, 12, 36, new double[] { -6 })]
        public void GetSolutionOfQuadraticEquation(double a, double b, double c, double[] expected)
        {
            Assert.AreEqual(expected, HomeWork_3.GetSolutionOfQuadraticEquation(a, b, c));
        }

        [TestCase(0, 1, 2)]
        public void GetSolutionOfQuadraticEquationNegativeTest(double x, double y, double z)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_3.GetSolutionOfQuadraticEquation(x, y, z));
        }

        [TestCase(11, "Одиннадцать")]
        [TestCase(23, "Двадцать " + "три")]
        [TestCase(19, "Девятнадцать")]
        [TestCase(99, "Девяносто " + "девять")]
        [TestCase(10, "Десять")]
        public void GetNameOfNumberTest(int a, string expected)
        {
            Assert.AreEqual(expected, HomeWork_3.GetNameOfNumber(a));
        }

        [TestCase(9)]
        [TestCase(100)]
        [TestCase(-87)]
        public void GetNameOfNumberNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_3.GetNameOfNumber(a));
        }

        [TestCase(1.2, 0.5, 3.1, false)]
        [TestCase(4.2, 6.5, 8.9, true)]
        [TestCase(3.4, 7.1, 3.0, false)]
        [TestCase(0.2, 1.5, 5.1, false)]
        [TestCase(6.7, 0.5, 7.2, true)]
        public void GetIsTriangleExistTest(double a, double b, double c, bool expected)
        {
            Assert.AreEqual(expected, HomeWork_3.GetIsTriangleExist(a, b, c));
        }

        [TestCase(-0.5, 1.6, 2.8)]
        [TestCase(0.5, -1.6, 2.8)]
        [TestCase(0.5, 1.6, -2.8)]
        [TestCase(0, 1.6, -2.8)]
        [TestCase(0.5, 0, -2.8)]
        [TestCase(0.5, 1.6, 0)]
        public void GetIsTriangleExistNegativeNest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_3.GetIsTriangleExist(a, b, c));
        }






    }
}
