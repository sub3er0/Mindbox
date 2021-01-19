using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculateAreaLibrary;
using System;

namespace UnitTestMindbox
{
    [TestClass]
    public class CalculateAreaLibraryTest
    {
        [TestMethod]
        public void CalculateCircleSquare()
        {
            Circle circle = new Circle(3);
            Assert.AreEqual(circle.Square(), 28.274, 0.001);
        }

        [TestMethod]
        public void CalculateTriangleSquare()
        {
            Triangle triangle = new Triangle(4, 5, 3);
            Assert.AreEqual(triangle.Square(), 6);
        }

        [TestMethod]
        public void CheckRectangular()
        {
            Triangle triangle = new Triangle(4, 5, 3);
            Assert.AreEqual(triangle.IsRectangular(), true);
        }
    }
}
