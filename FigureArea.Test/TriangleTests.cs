using NUnit.Framework;
using System;

namespace FigureArea.Test
{
    public class TriangleTests
    {
        [TestCase(10, 7, 15, 29.394)]
        [TestCase(5, 5, 6, 12)]
        public void CalculateAreaTest(double first, double second, double third, double expected)
        {
            Triangle triangle = new Triangle(first, second, third);
            double actual = triangle.CalculateArea();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 0)]
        [TestCase(-5, 5, -6)]
        public void CreateTriangleTest_WhenTriangleWithSuchSidesCannotExist_ShouldThrowArgumentException(double first, double second, double third)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(first, second, third));
        }

        [TestCase(6, 8, 10, true)]
        [TestCase(5, 5, 6, false)]
        public void CheckRightTriangleTest(double first, double second, double third, bool expected)
        {
            Triangle triangle = new Triangle(first, second, third);
            bool actual = triangle.CheckRightTriangle();
            Assert.AreEqual(expected, actual);
        }
    }
}