using FiguresClassLibrary;
using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_unitTest
{
    [TestClass]
    public class EqualObjectsTest
    {
        [TestMethod]
        public void ValidTestCheck1()
        {
            FigureActions actions = new FigureActions();

            Figure[] array = { new Triangle(20, 30, 40) };

            Figure[] t_sameFigures = actions.GetSameFiguresArray(array[0], array);

            Figure[] ex_sameFigures = { new Triangle(20, 30, 40) };

            CollectionAssert.AreEqual(ex_sameFigures, t_sameFigures);
        }

        [TestMethod]
        public void ValidTestCheck2()
        {
            FigureActions actions = new FigureActions();

            Figure[] array = { new Triangle(20, 30, 40), new Circle(5), new Triangle(20, 30, 40),
            new Rectangle(10, 20, 10, 20)};

            Figure[] t_sameFigures = actions.GetSameFiguresArray(array[0], array);

            Figure[] ex_sameFigures = { new Triangle(20, 30, 40), new Triangle(20, 30, 40) };

            CollectionAssert.AreEqual(ex_sameFigures, t_sameFigures);
        }
    }
}
