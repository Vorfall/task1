using FiguresClassLibrary;
using FileExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace task2_unitTest
{
    [TestClass]
    public class CircleCreationTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationBySides1()
        {
            double r = -2;
            Circle circle = new Circle(r);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationBySides2()
        {
            double r = 0;
            Circle circle = new Circle(r);
        }

       
        [TestMethod]
        public void CircleCreationBySides1()
        {
            double r = 2;

            double rExpected = 2;

            Circle circleTest = new Circle(r);

            Circle circleExcept = new Circle(rExpected);

            Assert.AreEqual(circleExcept, circleTest);
        }

        
        [TestMethod]
        public void CircleCreationBySides3()
        {
            double r = 1000;

            double rExpected = 1000;

            Circle circleTest = new Circle(r);

            Circle circleExcept = new Circle(rExpected);

            Assert.AreEqual(circleExcept, circleTest);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationByCoords1()
        {
            double x1 = 0;
            double y1 = 0;

            double x2 = 0;
            double y2 = 0;
            Circle circle = new Circle(x1,y1,x2,y2);
        }

        

        [TestMethod]
         public void CircleCreationByCoords1()
        {
            double p1x1 = 2;
            double p1y1 = 2;

            double p1x2 = -2;
            double p1y2 = -2;

            double p2x1 = 2;
            double p2y1 = 2;

            double p2x2 = -2;
            double p2y2 = -2;

            Circle circleTest = new Circle(p1x1, p1y1, p1x2, p1y2);

            Circle circleExcept = new Circle(p2x1, p2y1, p2x2, p2y2);

            Assert.AreEqual(circleExcept, circleTest);
        }

        [TestMethod]
        public void CircleCreationByCoords2()
        {
            double p1x1 = -7;
            double p1y1 = 2;

            double p1x2 = 5;
            double p1y2 = 5;

            double p2x1 = -7;
            double p2y1 = 2;

            double p2x2 = 5;
            double p2y2 = 5;

            Circle circleTest = new Circle(p1x1, p1y1, p1x2, p1y2);

            Circle circleExcept = new Circle(p2x1, p2y1, p2x2, p2y2);

            Assert.AreEqual(circleExcept, circleTest);
        }

        [TestMethod]
        public void CircleCreationByCoords3()
        {
            double p1x1 = -1;
            double p1y1 = 0;

            double p1x2 = 5;
            double p1y2 = 5;

            double p2x1 = -1;
            double p2y1 = 0;

            double p2x2 = 5;
            double p2y2 = 5;

            Circle circleTest = new Circle(p1x1, p1y1, p1x2, p1y2);

            Circle circleExcept = new Circle(p2x1, p2y1, p2x2, p2y2);

            Assert.AreEqual(circleExcept, circleTest);
        }
    }
}
