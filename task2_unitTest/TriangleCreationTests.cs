using System;
using FiguresClassLibrary;
using FileExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task2_unitTest
{
    [TestClass]
    public class TriangleCreationTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongTriangleCreationBySides1()
        {
            double A = 2;
            double B = 4;
            double C = 6;

            Triangle triangle = new Triangle(A, B, C);
        }

        public void WrongTriangleCreationBySides2()
        {
            double A = 3;
            double B = -6;
            double C = 0;

            Triangle triangle = new Triangle(A, B, C);
        }

        public void WrongTriangleCreationBySides3()
        {
            double A = -2;
            double B = -4;
            double C = 28;

            Triangle triangle = new Triangle(A, B, C);
        }

        [TestMethod]
        public void TriangleCreationBySides1()
        {
            double A = 5;
            double B = 6;
            double C = 7;

            Triangle triangleToTest = new Triangle(A, B, C);

            Triangle triangleToExcept = new Triangle(5, 6, 7);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }

        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongTriangleCreationByCoords1()
        {
            double x1 = 0;
            double y1 = 0;

            double x2 = -1;
            double y2 = -1;

            double x3 = -1;
            double y3 = -1;

            Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongTriangleCreationByCoords2()
        {
            double x1 = 9;
            double y1 = 9;

            double x2 = 9;
            double y2 = 9;

            double x3 = 9;
            double y3 = 9;

            Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);
        }

       

        [TestMethod]
        public void TriangleCreationByCoords1()
        {
            double x1 = 1;
            double y1 = 2;

            double x2 = 4;
            double y2 = 5;

            double x3 = -1;
            double y3 = -1;

            Triangle triangleToTest = new Triangle(x1, y1, x2, y2, x3, y3);

            Triangle triangleToExcept = new Triangle(1, 2, 4, 5, -1, -1);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }

        
        [TestMethod]
        public void TriangleCreationByCoords2()
        {
            double x1 = -5;
            double y1 = -5;

            double x2 = 200;
            double y2 = 200;

            double x3 = 5;
            double y3 = -5;

            Triangle triangleToTest = new Triangle(x1, y1, x2, y2, x3, y3);

            Triangle triangleToExcept = new Triangle(-5, -5, 200, 200, 5, -5);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }
    }
}
