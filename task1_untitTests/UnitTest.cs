using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using epam_task_1;

namespace task1_untitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGDCPositiveValues1()
        {
            //arrange
            int a = 9;
            int b = 99;
            int testResult = 9;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        public void TestGDCPositiveValues2()
        {
            //arrange
            int a = 2452;
            int b = 222;
            int testResult = 2;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

       

        [TestMethod]
        public void TestGDCNegativeValues()
        {
            //arrange
            int a = -5;
            int b = -150;
            int testResult = 5;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCZeroValues()
        {
            //arrange
            int a = 0;
            int b = 0;
            int testResult = 0;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCNegativePositiveValues()
        {
            //arrange
            int a = -4;
            int b = 180;
            int testResult = 4;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCPositiveValues3()
        {
            //arrange
            int a = 4;
            int b = 156;
            int c = 1256;
            int testResult = 4;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCPositiveValues4()
        {
            //arrange
            int a = 1;
            int b = 1;
            int c = 456451;
            int testResult = 1;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }
        [TestMethod]
        public void TestGDC2Positive1NegativeValues()
        {
            //arrange
            int a = 5;
            int b = -155;
            int c = 1455;
            int testResult = 5;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        
        [TestMethod]
        public void TestGDC4PositiveValues2()
        {
            //arrange
            int a = 5;
            int b = 76522;
            int c = 1455;
            int d = 40;
            int testResult = 1;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, d, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDC4PositiveValues3()
        {
            //arrange
            int a = 2;
            int b = 4;
            int c = 32;
            int d = 246;
            int testResult = 2;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, d, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDC4EqualValues()
        {
            //arrange
            int a = 4312;
            int b = 4312;
            int c = 4312;
            int d = 4312;
            int testResult = 4312;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, d, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        

        [TestMethod]
        public void TestGDC3Positive1NegativeValues()
        {
            //arrange
            int a = 5;
            int b = -155;
            int c = 1455;
            int d = 204520;
            int testResult = 5;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, d, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }



        [TestMethod]
        public void TestGDC4Positive1NegativeValues()
        {
            //arrange
            int a = 5;
            int b = -155;
            int c = 213213;
            int d = -155;
            int e = 4581200;

            int testResult = 1;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGDCEuclideanMethod(a, b, c, d, e, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }


        [TestMethod]
        public void TestSteinWith2PositiveValues1()
        {
            //arrange
            int a = 5;
            int b = 155;
            int testResult = 5;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGCDStain(a, b, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        

       
       

       
        [TestMethod]
        public void TestSteinWithNegativePositiveValues()
        {
            //arrange
            int a = -15;
            int b = 170;
            int testResult = 5;

            long time = 0;

            //act
            EuclidMethods testEuclid = new EuclidMethods();
            int result = testEuclid.GetGCDStain(a, b, out time);

            //assert
            Assert.AreEqual(testResult, result, 0.001, "Something went wrong");
        }

        
    }
}
