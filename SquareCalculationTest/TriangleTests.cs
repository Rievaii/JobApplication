using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculation.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        SquareCalculation.Triangle triangle = new SquareCalculation.Triangle();
        

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
    "параметры должны быть больше нуля")]
        public void TriangleNullParams()
        {
            
            Assert.AreEqual(0, triangle.GetSquare(0, 0, 0));
        }

        [TestMethod()]

        public void TriangleTestParams()
        {
            //Arrange
            double a, b, c;

            //Act
            a = 3; b = 4; c = 5;
            double Actual = triangle.GetSquare(a, b, c);

            Assert.AreEqual(6, Actual);
        }

        [TestMethod()]

        public void isRectangularTest()
        {
            //Arrange
            double a, b, c;

            //Act

            a = 3; b = 4; c = 5;
            double Actual = triangle.GetSquare(a, b, c);

            Assert.AreEqual(true, triangle.isRectangular);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
   "стороны не образуют треугольник")]
        public void NotATriangleTest()
        {
            Assert.AreEqual(0, triangle.GetSquare(0, 0, 0));
        }
    }
}