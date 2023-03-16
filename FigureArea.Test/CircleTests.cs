using NUnit.Framework;
using System;

namespace FigureArea.Test
{
    public class CircleTests
    {
        [TestCase(10, 314.159)]
        [TestCase(2.25, 15.904)]
        public void CalculateAreaTest(double radius, double expected)
        {
            Circle circle = new Circle(radius);
            double actual = circle.CalculateArea();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void CreateCircleTest_WhenRadiusLessOrEqualZero_ShouldThrowArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}