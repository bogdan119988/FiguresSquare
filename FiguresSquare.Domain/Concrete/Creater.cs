using FiguresSquare.Domain.Abstract;
using FiguresSquare.Domain.Concrete.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresSquare.Domain.Concrete
{
    public class Creater : ICreater
    {
        public Figure CreateFigure(string type)
        {
            switch (type)
            {
                case "Triangle":
                    return new Triangle();
                case "Circle":
                    return new Circle();
            }
            return null;
        }
    }
}
