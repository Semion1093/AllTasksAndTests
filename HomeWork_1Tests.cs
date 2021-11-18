using NUnit.Framework;
using System;

namespace AllTasks.Tests
{
    public class HomeWork_1Tests
    {
        [TestCase(11, 0.5, "привет, 11!\n11 + 0,5 = 11,5\nпока, 0,5...")]
        [TestCase(0, -9.1, "привет, 0!\n0 + -9,1 = -9,1\nпока, -9,1...")]
        [TestCase(0, 0.0, "привет, 0!\n0 + 0 = 0\nпока, 0...")]
        [TestCase(1000, 0.12345, "привет, 1000!\n1000 + 0,12345 = 1000,12345\nпока, 0,12345...")]
        [TestCase(1, 1.1, "привет, 1!\n1 + 1,1 = 2,1\nпока, 1,1...")]
        public void GetHelloByeStringTest(int a, double b, string expected)
        {
            Assert.AreEqual(expected, HomeWork_1.GetHelloByeString(a, b));
        }

        [TestCase(1, 0, -5.0)]
        [TestCase(0, 1, 1.0)]
        [TestCase(-1, 1, -2.0)]
        [TestCase(0, 10, 1000.0)]
        [TestCase(1, -1, -3.0)]
        public void DecisideTaskTest(int a, int b, double expected)
        {
            Assert.AreEqual(expected, HomeWork_1.DecisideTask(a, b));
        }
        [TestCase(0, 0)]
        [TestCase(5, 5)]
        public void DecisideTaskNegativeTest(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_1.DecisideTask(a, b));
        }

        [TestCase("Привет", "Пока", "Пока" + "Привет")]
        [TestCase("До свидания", "Здравствуйте", "Здравствуйте" + "До свидания")]
        [TestCase("5", "6", "6" + "5")]
        [TestCase("123", "321", "321" + "123")]
        [TestCase("000", "111", "111" + "000")]
        public void ChangeStringsTest(string s1, string s2, string expected)
        {
            Assert.AreEqual(expected, HomeWork_1.ChangeStrings(s1, s2));
        }
        [TestCase(" "," ")]
        [TestCase("Привет", " ")]
        public void ChangeStringsNegativeTest(string s1, string s2)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_1.ChangeStrings(s1, s2));
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(1, 1, 1, 0)]
        [TestCase(-1, -1, -1, 0)]
        [TestCase(2, -2, 2, 2)]
        [TestCase(3, 2, 1, -0.3333333333333333)]
        public void SolveLinearEquationTest(int a, int b, int c, double expected)
        {
            Assert.AreEqual(expected, HomeWork_1.SolveLinearEquation(a, b, c));
        }

        [TestCase(0, 0, 0)]
        public void SolveLinearEquationNegativeTest(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => HomeWork_1.SolveLinearEquation(a, b, c));
        }
    }
}