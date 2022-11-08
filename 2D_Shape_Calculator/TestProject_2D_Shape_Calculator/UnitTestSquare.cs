using _2D_Shape_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_2D_Shape_Calculator
{
    [TestClass]
    public class UnitTestSquareGetPerimeter
    {
        [TestMethod]
        public void TestCase1()
        {
            // Arrange
            var square = new Square(-20);
            double expect = 0;
            // Act
            double actual = square.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void TestCase2()
        {
            // Arrange
            var square = new Square(-0.00001);
            double expect = 0;
            // Act
            double actual = square.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            // Arrange
            var square = new Square(0);
            double expect = 0;
            // Act
            double actual = square.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            // Arrange
            var square = new Square(0.0001);
            double expect = 0.0004;
            // Act
            double actual = square.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual, 0.0001);
        }

        [TestMethod]
        public void TestCase5()
        {
            // Arrange
            var square = new Square(12);
            double expect = 48;
            // Act
            double actual = square.GetPerimeter();
            // Assert
            Assert.AreEqual(expect, actual, 0.001);
        }
    }

    [TestClass]
    public class UnitTestSquareGetArea
    {
        [TestMethod]
        public void TestCase1()
        {
            // Arrange
            var square = new Square(-12);
            double expect = 0;
            // Act
            double actual = square.GetArea();
            // Assert
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void TestCase2()
        {
            // Arrange
            var square = new Square(-0.001);
            double expect = 0;
            // Act
            double actual = square.GetArea();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            // Arrange
            var square = new Square(0);
            double expect = 0;
            // Act
            double actual = square.GetArea();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            // Arrange
            var square = new Square(0.00001);
            double expect = 0.0000000001;
            // Act
            double actual = square.GetArea();
            // Assert
            Assert.AreEqual(expect, actual, 0.0000000001);
        }

        [TestMethod]
        public void TestCase5()
        {
            // Arrange
            var square = new Square(25);
            double expect = 625;
            // Act
            double actual = square.GetArea();
            // Assert
            Assert.AreEqual(expect, actual, 0.001);
        }
    }
}
