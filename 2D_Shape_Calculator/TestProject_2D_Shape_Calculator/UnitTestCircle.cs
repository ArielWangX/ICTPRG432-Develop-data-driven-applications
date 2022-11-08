using _2D_Shape_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject_2D_Shape_Calculator
{
    [TestClass]
    public class UnitTestCircleGetPerimeter
    {
        [TestMethod]
        public void TestCase1()
        {
            // Arrange
            var circle = new Circle(-15);
            double expect = 0;
            // Act
            double actual = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void TestCase2()
        {
            // Arrange
            var circle = new Circle(-0.0001);
            double expect = 0;
            // Act
            double actual = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            // Arrange
            var circle = new Circle(0);
            double expect = 0;
            // Act
            double actual = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            // Arrange
            var circle = new Circle(0.0001);
            double expect = 0.000628319;
            // Act
            double actual = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual, 0.000000001);
        }

        [TestMethod]
        public void TestCase5()
        {
            // Arrange
            var circle = new Circle(20);
            double expect = 125.66371;
            // Act
            double actual = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual, 0.0001);
        }
    }

    [TestClass]
    public class UnitTestCircleGetArea
    {
        [TestMethod]
        public void TestCase1()
        {
            // Arrange
            var circle = new Circle(-2);
            double expect = 0;
            // Act
            double actual = circle.GetArea();
            // Assert
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void TestCase2()
        {
            // Arrange
            var circle = new Circle(-0.001);
            double expect = 0;
            // Act
            double actual = circle.GetArea();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            // Arrange
            var circle = new Circle(0);
            double expect = 0;
            // Act
            double actual = circle.GetArea();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            // Arrange
            var circle = new Circle(0.01);
            double expect = 0.000314;
            // Act
            double actual = circle.GetArea();
            // Assert
            Assert.AreEqual(expect, actual, 0.000001);
        }

        [TestMethod]
        public void TestCase5()
        {
            // Arrange
            var circle = new Circle(50);
            double expect = 7853.98;
            // Act
            double actual = circle.GetArea();
            // Assert
            Assert.AreEqual(expect, actual, 0.01);
        }
    }
}
