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
    public class CircleTests
    {
        SquareCalculation.Circle circle = new SquareCalculation.Circle();
        [TestMethod()]
        public void GetSquareTestNullParams()
        {
            Assert.AreEqual(0, circle.GetSquare(0));
        }

        [TestMethod]
        public void CircleCorrectParamsTest()
        {
            //Arrange
            double R = 5;
            double Result = 79;

            //Act
            double Actual = circle.GetSquare(R);

            //Assert
            Assert.AreEqual(Result, Math.Round(Actual));
        }
    }
}