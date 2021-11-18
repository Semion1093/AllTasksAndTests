using NUnit.Framework;
using System;

namespace AllTasks.Tests
{
    class HomeWork_5Tests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 5)]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 0, 10)]
        [TestCase(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, 10, 0)]
        [TestCase(new int[] { -1, 4, -5, 3, -9, 4, 3, -1, 0, 0 }, 4, 6)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 4, 0)]
        public void GetSummaryOfEvenAndOddElementsInArrayTest(int[] array, int expected1, int expected2)
        {
            Assert.AreEqual((expected1, expected2), HomeWork_5.GetSummaryOfEvenAndOddElementsInArray(array));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 1, 2, 3, 4, 5, 9, 7, 8, 15, 10 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 },
            new int[] { -1, -2, -3, -4, -5, -9, -7, -8, -15, -10 })]
        [TestCase(new int[] { 1, -1, 2, -2, 3, -3, 0 }, new int[] { 1, -1, 0, -2, 3, 1, 0 })]
        [TestCase(new int[] { 0, 0, 1, 0, 0, 1, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 10, 3, 6, 3, 2, 1, 0 }, new int[] { 10, 3, 13, 3, 2, 5, 0 })]
        public void ReplaceEveryThirdElementSumOfTwoPreviousTest(int[] array, int[] expected)
        {
            Assert.AreEqual(expected, HomeWork_5.ReplaceEveryThirdElementSumOfTwoPrevious(array));
        }

        [TestCase(new int[] { 1 }, new int[] { -2 }, new int[] { 1, -2 })]
        [TestCase(new int[] { 4, -7, 3, 7 }, new int[] { }, new int[] { 4, -7, 3, 7 })]
        [TestCase(new int[] { }, new int[] { 2, -4, 6 }, new int[] { 2, -4, 6 })]
        [TestCase(new int[] { 0, 0 }, new int[] { 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, -2, -3, 4, 5 }, new int[] { 6, 7, 8, 9, -10 },
            new int[] { 1, -2, -3, 4, 5, 6, 7, 8, 9, -10 })]
        public static void MergeTwoArraysIntoOneTest(int[] array1, int[] array2, int[] expected)
        {
            Assert.AreEqual(expected, HomeWork_5.MergeTwoArraysIntoOne(array1, array2));
        }

        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1, -2, 3 }, new int[] { 3, -2, 1 })]
        [TestCase(new int[] { 1, 2, 3, -4, -5 }, new int[] { -4, -5, 3, 1, 2 })]
        [TestCase(new int[] { 1, 1, 2, -3, 3 }, new int[] { -3, 3, 2, 1, 1 })]
        [TestCase(new int[] { 9, 1, -1 }, new int[] { -1, 1, 9 })]
        public void SwapFirstAndSecondHalfOfArrayTest(int[] array, int[] expected)
        {
            Assert.AreEqual(expected, HomeWork_5.SwapFirstAndSecondHalfOfArray(array));
        }

        [TestCase(new int[] { -1, 2, -3, 4, 5 }, new int[] { -3, 4, 5, -1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [TestCase(new int[] { 7, 6, 5, 4, 3, 2, 1 }, new int[] { 3, 2, 1, 7, 6, 5, 4 })]
        [TestCase(new int[] { 6, 9, -8, 2, 10, 3, 8, 3, -9, 2 },
            new int[] { 3, -9, 2, 6, 9, -8, 2, 10, 3, 8 })]
        [TestCase(new int[] { 10, -20, 30, -40, 50 }, new int[] { 30, -40, 50, 10, -20 })]
        public void ShiftArrayTest(int[] array, int[] expected)
        {
            Assert.AreEqual(expected, HomeWork_5.ShiftArray(array));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 4, 3, 5 })]
        [TestCase(new int[] { 0, -1, 0, -1, 0, -1 }, new int[] { -1, 0, -1, 0, -1, 0 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 4, 5, 2, 3, 1 })]
        [TestCase(new int[] { 0, 3, 3, -4, 9, 0, -5 }, new int[] { 3, 0, -4, 3, 0, 9, -5 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        public void ConvertPositionsOfEvenElementsToOddTest(int[] array, int[] expected)
        {
            Assert.AreEqual(expected, HomeWork_5.ConvertPositionsOfEvenElementsToOdd(array));
        }

        [TestCase(new int[] { -6, 3, -9, 2, 5, 10, -9, 6, 10, 6 }, 5, 0)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, -5 }, 5, 5)]
        [TestCase(new int[] { 1, 2, 0, 2, -1, -1 }, 1, 0)]
        [TestCase(new int[] { 1, 1, 1 }, 0, 0)]
        [TestCase(new int[] { 0, 0, 1, 0 }, 2, 1)]
        public void GetMinimumModuloElementAndSummaryOfElementsAfterZeroTest(int[] array,
            int expected1, int expected2)
        {
            Assert.AreEqual((expected1, expected2),
                HomeWork_5.GetMinimumModuloElementAndSummaryOfElementsAfterZero(array));
        }

        [TestCase(new int[] { 5, 4, 3, 2, 1, 0 }, new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -5, 4, -3, 2, -1, 0 }, new int[] { -5, -3, -1, 0, 2, 4 })]
        [TestCase(new int[] { 1, -3, -3, 10, 6 }, new int[] { -3, -3, 1, 6, 10 })]
        [TestCase(new int[] { 0, 1, 0, 1 }, new int[] { 0, 0, 1, 1})]
        [TestCase(new int[] { 1, 0, -1 }, new int[] { -1, 0, 1 })]

        public void SortInertionAlgorithmTest(int[] array, int[] expected)
        {
            Assert.AreEqual(expected, HomeWork_5.SortInertionAlgorithm(array));
        }

        [TestCase(new int[] { 5, 4, 3, 2, 1, 0 }, new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -5, 4, -3, 2, -1, 0 }, new int[] { -5, -3, -1, 0, 2, 4 })]
        [TestCase(new int[] { 1, -3, -3, 10, 6 }, new int[] { -3, -3, 1, 6, 10 })]
        [TestCase(new int[] { 0, 1, 0, 1 }, new int[] { 0, 0, 1, 1 })]
        [TestCase(new int[] { 1, 0, -1 }, new int[] { -1, 0, 1 })]
        public void SortSelectionAlgorithmTest(int[] array, int[] expected)
        {
            Assert.AreEqual(expected, HomeWork_5.SortSelectionAlgorithm(array));
        }
    }
}
