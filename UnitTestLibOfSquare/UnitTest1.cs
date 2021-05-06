using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfSquare;
using System;

namespace UnitTestLibOfSquare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleIsRectangular()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Triangle myTriangle = new Triangle(a, b, c);
            myTriangle.CheckOfTriangle();
        }
        [TestMethod]
        public void LargeNumbersOfCircle()
        {
            int a = 1000;
            int b = 2000;
            int c = 3000;
            Triangle myTriangle = new Triangle(a, b, c);
            Square square = new Square();
            square.SquareOfCircleFromRadius(100000);
            square.SquareOfCircleFromTriangle(myTriangle);
        }
        [TestMethod]
        public void NegativeValues() 
        {
            int a = -1000;
            int b = -2000;
            int c = -3000;
            Triangle myTriangle = new Triangle(a, b, c);
            Square square = new Square();
            square.SquareOfCircleFromRadius(-100000);
            square.SquareOfCircleFromTriangle(myTriangle);
        }
    }
}
