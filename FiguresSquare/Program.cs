using FiguresSquare.Domain.Abstract;
using FiguresSquare.Domain.Concrete;
using FiguresSquare.Domain.Concrete.Shapes;
using System;

namespace FiguresSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreater creater = new Creater();

            Figure figure1 = creater.CreateFigure("Circle");
            double square1 = 0;
            try
            {
                square1 = figure1.Square(3);
                Console.WriteLine("Площадь первой фигуры = " + square1.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Figure figure2 = creater.CreateFigure("Triangle");
            double square2 = 0;

            try
            {
                square2 = figure2.Square(1, 2, 3);
                Console.WriteLine("Площадь второй фигуры = " + square2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            ITriangleMethod triangle = new Triangle();
            try
            {
                string mes = triangle.isRectangular(3, 5, 4);
                Console.WriteLine(mes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
