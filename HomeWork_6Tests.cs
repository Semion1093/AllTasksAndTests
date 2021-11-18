using NUnit.Framework;
using System.Collections.Generic;

namespace AllTasks.Tests
{
    class HomeWork_6Tests
    {
        [Test]
        public static void ChangeSignToTheOppositeTest()
        {
            int[,] matrix = new int[,] { { 1, 1, 1, 1, 1 },
                                         { 1, 0, 0, 0, 1 },
                                         { 1, 0, 0, 0, 1 },
                                         { 1, 1, 1, 1, 1 } };

            int[,] actual = HomeWork_6.ChangeSignToTheOpposite(matrix);

            int[,] expected = new int[,] { { -1, -1, -1, -1, -1 },
                                           { -1,  0,  0,  0, -1 },
                                           { -1,  0,  0,  0, -1 },
                                           { -1, -1, -1, -1, -1 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void GetMultiplicationTableTest()
        {
            int[,] actual = HomeWork_6.GetMultiplicationTable();

            int[,] expected = new int[,] { { 1,  2,  3,  4,  5,  6,  7,  8,  9  },
                                           { 2,  4,  6,  8,  10, 12, 14, 16, 18 },
                                           { 3,  6,  9,  12, 15, 18, 21, 24, 27 },
                                           { 4,  8,  12, 16, 20, 24, 28, 32, 36 },
                                           { 5,  10, 15, 20, 25, 30, 35, 40, 45 },
                                           { 6,  12, 18, 24, 30, 36, 42, 48, 54 },
                                           { 7,  14, 21, 28, 35, 42, 49, 56, 63 },
                                           { 8,  16, 24, 32, 40, 48, 56, 64, 72 },
                                           { 9,  18, 27, 36, 45, 54, 63, 72, 81 } };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void GetChessBoardTest()
        {
            int[,] actual = HomeWork_6.GetChessBoard();
            int[,] expected = new int[,] { { 1, 0, 1, 0, 1, 0, 1, 0 },
                                           { 0, 1, 0, 1, 0, 1, 0, 1 },
                                           { 1, 0, 1, 0, 1, 0, 1, 0 },
                                           { 0, 1, 0, 1, 0, 1, 0, 1 },
                                           { 1, 0, 1, 0, 1, 0, 1, 0 },
                                           { 0, 1, 0, 1, 0, 1, 0, 1 },
                                           { 1, 0, 1, 0, 1, 0, 1, 0 },
                                           { 0, 1, 0, 1, 0, 1, 0, 1 } };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsSeatingArrangementsFalseTest()
        {
            int[,] matrix = new int[,] { { 0, 1, 0, 0, 1, 0 },
                                         { 0, 0, 1, 0, 1, 0 },
                                         { 0, 1, 0, 0, 0, 1 },
                                         { 0, 1, 0, 1, 1, 0 } };

            bool expected = false;

            bool actual = HomeWork_6.IsSeatingArrangementsTrue(matrix);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsseatingArrangementsTrueTest()
        {
            int[,] matrix = new int[,] { { 0, 1, 0, 0, 1, 0 },
                                         { 0, 0, 1, 0, 1, 0 },
                                         { 0, 1, 0, 0, 0, 1 },
                                         { 0, 1, 0, 0, 1, 0 } };

            bool expected = true;

            bool actual = HomeWork_6.IsSeatingArrangementsTrue(matrix);

            Assert.AreEqual(expected, actual);
        }

        public List<decimal> GetResOfShopsVariants()
        {
           return new List<decimal>(new decimal[] { 295.9m, 299.1m, 249.3m, 309.9m, 307.8m, 
                441.6m, 336.6m, 260.9m, 381.3m, 205.5m });
        }
        public List<decimal> GetResOfMonthVariants()
        {
            return new List<decimal>(new decimal[] { 42.72m, 52.85m, 59.32m, 63.06m, 57.07m, 33.77m });
        }

        [Test]
        public void GetResulstOFShopsTest()
        {
            List<decimal> expected1 = GetResOfShopsVariants();
            List<decimal> expected2 = GetResOfMonthVariants();
            decimal expectedmin = 11.0m;
            decimal expectedmax = 96.7m;
            decimal[,] amounts = new decimal[,] { { 23.7m, 67.5m, 92.6m, 65.8m, 12.0m, 34.3m },
                                                { 94.5m, 36.8m, 36.6m, 24.1m, 95.9m, 11.2m },
                                                { 14.0m, 85.3m, 27.1m, 67.8m, 43.0m, 12.1m },
                                                { 34.6m, 31.3m, 65.3m, 76.3m, 87.6m, 14.8m},
                                                { 15.0m, 83.2m, 76.9m, 32.6m, 47.2m, 52.9m },
                                                { 73.5m, 76.3m, 88.2m, 94.7m, 32.6m, 76.3m },
                                                { 72.0m, 43.9m, 44.0m, 45.2m, 78.3m, 53.2m },
                                                { 72.0m, 44.8m, 33.2m, 41.1m, 56.1m, 13.7m },
                                                { 13.2m, 34.6m, 83.1m, 96.7m, 95.5m, 58.2m },
                                                { 14.7m, 24.8m, 46.2m, 86.3m, 22.5m, 11.0m } };

            (List<decimal>, List<decimal>, decimal, decimal) actual = HomeWork_6.GetResulstOFShops(amounts);

            Assert.AreEqual((expected1, expected2, expectedmin, expectedmax), actual);
        }


        [Test]
        public void GetLargestNeighboursTest()
        {
            int[,] matrix = new int[,] { { 11, 3, 8, 0, 1 },
                                         { 0, 12, 4, 1, 5 },
                                         { 19, 9, 1, 6, 4 } };

            int actual = HomeWork_6.GetLargestNeighbours(matrix);
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFilInCharArrayTest()
        {
            int[,] actual = HomeWork_6.GetFilInCharArray();

            int[,] expected = new int[,] { { '1', '1', '1', '1', '1', '1', '1' },
                                           { '0', '1', '1', '1', '1', '1', '0' },
                                           { '0', '0', '1', '1', '1', '0', '0' },
                                           { '0', '0', '0', '1', '0', '0', '0' },
                                           { '0', '0', '1', '1', '1', '0', '0' },
                                           { '0', '1', '1', '1', '1', '1', '0' },
                                           { '1', '1', '1', '1', '1', '1', '1' }, };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetMatrixMultiplicationTest()
        {
            int[,] first = new int[,] { { 1, 2, 3},
                                        { 4, 5, 6} };

            int[,] second = new int[,] { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 } };

            int[,] expected = new int[,] { { 22, 28 },
                                           { 49, 64 } };

            int[,] actual = HomeWork_6.GetMatrixMultiplication(first, second);

            Assert.AreEqual(expected, actual);
        }


    }
}
