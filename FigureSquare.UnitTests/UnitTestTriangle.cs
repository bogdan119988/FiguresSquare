using FiguresSquare.Domain.Abstract;
using FiguresSquare.Domain.Concrete;
using FiguresSquare.Domain.Concrete.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare.UnitTests
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestMethodCorrectResult()
        {
            double result = 5.56;
            ICreater creater = new Creater();
            Figure figure = creater.CreateFigure("Triangle");

            double square = figure.Square(2,7,6);

            Assert.AreEqual(result, square);
        }

        [TestMethod]
        public void TestMethodIncorrectResult()
        {
            ICreater creater = new Creater();
            Figure figure = creater.CreateFigure("Triangle");

            Assert.ThrowsException<Exception>(() => figure.Square(-2, 7, 6));
        }

        [TestMethod]
        public void TestMethodIncorrectResult2()
        {
            ICreater creater = new Creater();
            Figure figure = creater.CreateFigure("Triangle");
            string errorMessage = "Сумма длин двух любых сторон треугольника меньше длины оставшейся стороны!!!\n";

            Exception exception = Assert.ThrowsException<Exception>(() => figure.Square(2, 7, 5));

            Assert.AreEqual(errorMessage, exception.Message);
        }

        [TestMethod]
        public void TestMethodParameterException()
        {
            ICreater creater = new Creater();
            Figure figure = creater.CreateFigure("Triangle");
            string errorMessage = "Количество передаваемых параметров не соответствует количеству принимаемых параметров!!!\n";

            Exception exception = Assert.ThrowsException<Exception>(() => figure.Square(2, 7));

            Assert.AreEqual(errorMessage, exception.Message);
        }

        [TestMethod]
        public void TestMethodIsNotRectangular()
        {
            ITriangleMethod triangle = new Triangle();
            string result = triangle.isRectangular(2,7,6);
            string Message = "Данный треугольник не является прямоугольным";

            Assert.AreEqual(Message, result);
        }

        [TestMethod]
        public void TestMethodIsRectangular()
        {
            ITriangleMethod triangle = new Triangle();
            string result = triangle.isRectangular(3, 5, 4);
            string Message = "Данный треугольник является прямоугольным";

            Assert.AreEqual(Message, result);
        }
    }
}
