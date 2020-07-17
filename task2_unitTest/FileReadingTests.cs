using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresClassLibrary;
using System.IO;

namespace task2_unitTest
{
     [TestClass]
    public class FileReadingTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void FilePathValidTest()
        {
            string path = @"Test.txt";

            FileReader reader = new FileReader();

            Figure[] testArray = reader.ReadFile(path);
        }

        

       

        [TestMethod]
        public void PathValidWithValidAllFigresTest()
        {
            string path = @"E:\epam_training_task1-master\FileExtensionsLibrary1\ComleteFigures.txt";

            FileReader reader = new FileReader();

            Figure[] t_array = reader.ReadFile(path);

            Figure[] ex_array = { new Triangle(30, 40, 50), new Triangle(0, 0, 4, 5, 0, 1), new Circle(10), new Circle(1, 1, -1, -1), new Rectangle(10,20,10,20), new Rectangle(0,0,0,20,10,10,10,0)};

            CollectionAssert.AreEqual(ex_array, t_array);
        }
    }
}
