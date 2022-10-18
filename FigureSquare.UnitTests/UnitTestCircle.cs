using System;
using FiguresSquare.Domain.Abstract;
using FiguresSquare.Domain.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureSquare.UnitTests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestMethodCorrectResult()
        {
            double result = 78.54;
            ICreater creater = new Creater();
            Figure figure = creater.CreateFigure("Circle");

            double square = figure.Square(5);

            Assert.AreEqual(result, square);

        }

        [TestMethod]
        public void TestMethodIncorrectResult()
        {
            ICreater creater = new Creater();
            Figure figure = creater.CreateFigure("Circle");

            Assert.ThrowsException<Exception>(() => figure.Square(-5));
        }

        [TestMethod]
        public void TestMethodParameterException()
        {
            ICreater creater = new Creater();
            Figure figure = creater.CreateFigure("Circle");
            string errorMessage = "Количество передаваемых параметров не соответствует количеству принимаемых параметров!!!\n";

            Exception exception = Assert.ThrowsException<Exception>(() => figure.Square(2, 7, 5));

            Assert.AreEqual(errorMessage, exception.Message);
        }
    }
}
