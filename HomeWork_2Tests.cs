using NUnit.Framework;
using System;

namespace AllTasks.Tests
{
    public class HomeWork_2Tests
    {
        [TestCase(-999, 27)]
        [TestCase(100, 1)]
        [TestCase(-111, 3)]
        [TestCase(101, 2)]
        [TestCase(901, 10)]
        public void GetSumOfNumbersTest(int a, int expected)
        {
            Assert.AreEqual(expected, HomeWork_2.GetSumOfNumbers(a));
        }

        [TestCase(99)]
        [TestCase(-1000)]
        [TestCase(0)]   
        public void GetSumOfNumbersNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_2.GetSumOfNumbers(a));
        }

        [TestCase(0.0, -1.2, 3.5, true)]
        [TestCase(0.1, 0.2, 4.5, true)]
        [TestCase(-9.9, 8.8, 0.5, false)]
        [TestCase(0.0, -5.6, 8.0, true)]
        [TestCase(0.3, 0.3, 1.0, true)]
        public static void GetResOfShotTest(double x1, double y1, double radius, bool expected)
        {
            Assert.AreEqual(expected, HomeWork_2.GetResOfShot(x1, y1, radius));
        }

        [TestCase(1.0, -1.2, 0)]
        [TestCase(2.1, 1.6, -1)]
        public void GetResOfShotNegativeTest(double x1, double y1, double radius)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_2.GetResOfShot(x1, y1, radius));
        }

        [TestCase(777, false)]
        [TestCase(-123, false)]
        [TestCase(321, true)]
        [TestCase(-987, true)]
        [TestCase(111, false)]
        public void CompareNumbersTest(int a, bool expected)
        {
            Assert.AreEqual(expected, HomeWork_2.CompareNumbers(a));
        }

        [TestCase(99)]
        [TestCase(-1000)]
        [TestCase(0)]
        public void CompareNumbersNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_2.GetSumOfNumbers(a));
        }

        [TestCase(123, 321)]
        [TestCase(-111, 111)]
        [TestCase(567, 765)]
        [TestCase(102, 201)]
        [TestCase(988, 889)]
        public void ChangeNumbersTests(int a, int expected)
        {
            Assert.AreEqual(expected, HomeWork_2.ChangeNumbers(a));
        }

        [TestCase(99)]
        [TestCase(-1000)]
        [TestCase(0)]
        public void ChangeNumbersNegativeTests(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_2.GetSumOfNumbers(a));
        }

        [TestCase(1.0, true)]
        [TestCase(2.1, false)]
        [TestCase(-9.9, false)]
        [TestCase(0.0, true)]
        [TestCase(-0.8, false)]
        public void GetFractionalPartIsZeroOrNoTest(double a, bool expected)
        {
            Assert.AreEqual(expected, HomeWork_2.GetFractionalPartIsZeroOrNo(a));
        }
    }
}
