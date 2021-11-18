using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AllTasks.Tests
{
    class HomeWork_4Tests
    {
        public enum GetNumbersDividedOnAMockVariants { On50, On1000, On300, On123, On77 };

        public List<int> GetNumbersDividedOnAMock(GetNumbersDividedOnAMockVariants variant)
        {
            switch (variant)
            {
                case GetNumbersDividedOnAMockVariants.On50:
                    return new List<int>(
                        new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600,
                        650, 700, 750, 800, 850, 900, 950, 1000 });
                case GetNumbersDividedOnAMockVariants.On1000:
                    return new List<int>(
                        new int[] { 1000 });
                case GetNumbersDividedOnAMockVariants.On300:
                    return new List<int>(new int[] { 300, 600, 900 });
                case GetNumbersDividedOnAMockVariants.On123:
                    return new List<int>(new int[] { 123, 246, 369, 492, 615, 738, 861, 984 });
                case GetNumbersDividedOnAMockVariants.On77:
                    return new List<int>(new int[] { 77, 154, 231, 308, 385, 462, 539, 616, 
                        693, 770, 847, 924 });
                default: return null;
            }
        }

        [TestCase(50, GetNumbersDividedOnAMockVariants.On50)]
        [TestCase(1000, GetNumbersDividedOnAMockVariants.On1000)]
        [TestCase(300, GetNumbersDividedOnAMockVariants.On300)]
        [TestCase(123, GetNumbersDividedOnAMockVariants.On123)]
        [TestCase(77, GetNumbersDividedOnAMockVariants.On77)]

        public void GetNumbersDividedOnATest(int a, GetNumbersDividedOnAMockVariants variant)
        {
            List<int> expected = GetNumbersDividedOnAMock(variant);
            List<int> actual = HomeWork_4.GetNumbersDividedOnA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1001)]
        [TestCase(0)]
        [TestCase(-11)]
        public void GetNumbersDividedOnANegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_4.GetNumbersDividedOnA(a));
        }

        [TestCase(10, 4)]
        [TestCase(-15, 0)]
        [TestCase(21, 5)]
        [TestCase(51, 8)]
        [TestCase(88, 10)]
        public void NumbersWhoseSquareIsLessThanATest(int a, int expected)
        {
            Assert.AreEqual(expected, HomeWork_4.NumbersWhoseSquareIsLessThanA(a));
        }

        [TestCase(0)]
        public void NumbersWhoseSquareIsLessThanANegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_4.NumbersWhoseSquareIsLessThanA(a));
        }

        [TestCase(1, 1)]
        [TestCase(-2, -1)]
        [TestCase(10, 5)]
        [TestCase(-50, -25)]
        [TestCase(99, 33)]
        public void GetGreatestDivisorTest(int a, int expected)
        {
            Assert.AreEqual(expected, HomeWork_4.GetGreatestDivisor(a));
        }

        [TestCase(0)]
        public void GetGreatestDivisorNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_4.GetGreatestDivisor(a));
        }

        [TestCase(0, 3, 0)]
        [TestCase(9, -2, 7)]
        [TestCase(-15, 15, 0)]
        [TestCase(30, -2, 70)]
        [TestCase(0, 0, 0)]
        public void GetSumOfNumbersWhoseDivideOnSevenTest(int a, int b, int expected)
        {
            Assert.AreEqual(expected, HomeWork_4.GetSumOfNumbersWhoseDivideOnSeven(a, b));
        }

        [TestCase(5, 0, 5)]
        [TestCase(-7, 14, -7)]
        [TestCase(5, 2, 1)]
        [TestCase(-1, -1, -1)]
        [TestCase(888, 999, 111)]

        public void GetGreatestDivisorUsingEuclidAlgorithmTest(int a, int b, int expected)
        {
            Assert.AreEqual(expected, HomeWork_4.GetGreatestDivisorUsingEuclidAlgorithm(a, b));
        }

        [TestCase(3, 1)]
        [TestCase(10, 2)]
        [TestCase(56, 3)]
        [TestCase(98, 3)]
        [TestCase(100, 3)]
        public void FindNumberUsingHalfDivisionMethodTest(int a, int expected)
        {
            Assert.AreEqual(expected, HomeWork_4.FindNumberUsingHalfDivisionMethod(a));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void FindNumberUsingHalfDivisionMethodNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_4.FindNumberUsingHalfDivisionMethod(a));
        }

        [TestCase(123, 2)]
        [TestCase(468022, 0)]
        [TestCase(1110, 3)]
        [TestCase(98135, 4)]
        [TestCase(19, 2)]
        public void GetSummaryOfOddDigitsOfNumberTest(int a, int expected)
        {
            Assert.AreEqual(expected, HomeWork_4.GetSummaryOfOddDigitsOfNumber(a));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void GetSummaryOfOddDigitsOfNumberNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_4.GetSummaryOfOddDigitsOfNumber(a));
        }

        [TestCase(123, 321)]
        [TestCase(456, 654)]
        [TestCase(907, 709)]
        [TestCase(433, 334)]
        [TestCase(21, 12)]
        public void GetMirrorNumberTest(int a, int expected)
        {
            Assert.AreEqual(expected, HomeWork_4.GetMirrorNumber(a));
        }

        [TestCase(-14)]
        public void GetMirrorNumberNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_4.GetMirrorNumber(a));
        }

        public enum GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants { Num50, Num25, Num30, 
            Num33, Num20 }
        public List<int> GetNumbersWhichSumOfEvenMoreThanSumOfOddMock
            (GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants variant)
        {
            switch (variant)
            {
                case GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num50:
                    return new List<int>(new int[] { 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38, 
                            40, 41, 42, 43, 44, 46, 48 });
                case GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num25:
                    return new List<int>(
                        new int[] { 12, 14, 16, 18, 20, 21, 22, 24 });
                case GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num30:
                    return new List<int>(new int[] { 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 });
                case GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num33:
                    return new List<int>(new int[] { 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 });
                case GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num20:
                    return new List<int>(new int[] { 12, 14, 16, 18, 20 });
                default: return null;
            }
        }

        [TestCase(50, GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num50)]
        [TestCase(25, GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num25)]
        [TestCase(30, GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num30)]
        [TestCase(33, GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num33)]
        [TestCase(20, GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants.Num20)]

        public void GetNumbersWhichSumOfEvenMoreThanSumOfOddTest(int a,
            GetNumbersWhichSumOfEvenMoreThanSumOfOddMockVariants variant)
        {
            List<int> expected = GetNumbersWhichSumOfEvenMoreThanSumOfOddMock(variant);
            List<int> actual = HomeWork_4.GetNumbersWhichSumOfEvenMoreThanSumOfOdd(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void GetNumbersWhichSumOfEvenMoreThanSumOfOddNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_4.GetNumbersWhichSumOfEvenMoreThanSumOfOdd(a));
        }

        [TestCase(123, 40596, false)]
        [TestCase(0, -1, false)]
        [TestCase(100, 20, true)]
        [TestCase(1, 1, true)]
        [TestCase(23, 33, true)]
        public void AreIdenticalDigitsInTwoNumbersTest(int a, int b, bool expected)
        {
            Assert.AreEqual(expected, HomeWork_4.AreIdenticalDigitsInTwoNumbers(a, b));
        }
    }
}
