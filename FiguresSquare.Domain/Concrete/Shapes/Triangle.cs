using FiguresSquare.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresSquare.Domain.Concrete.Shapes
{
    public class Triangle : Figure, ITriangleMethod
    {
        public Triangle()
        {
            CountParameters = 3;
        }

        public override double Square(params double[] parameters)
        {
            string errorMessage = "";

            if (isValidParameters(out errorMessage, parameters) == true)
                return Math.Round(Math.Sqrt(Perimeter(parameters) * (Perimeter(parameters) - parameters[0]) * (Perimeter(parameters) - parameters[1]) * (Perimeter(parameters) - parameters[2])),2);
            throw new Exception(errorMessage);
        }

        protected override bool isValidParameters(out string message, params double[] parameters)
        {
            bool check = true;
            message = "";

            if (isCountParameters(parameters) == false)
            {
                check = false;
                message += "Количество передаваемых параметров не соответствует количеству принимаемых параметров!!!\n";
                return check;
            }
            

            if (parameters[0] < 0 || parameters[1] < 0 || parameters[2] < 0)
            {
                check = false;
                message += "Длина одной из стророн треугольника меньше нуля!!!\n";
            }

            if (((parameters[0] + parameters[1]) <= parameters[2]) ||
                ((parameters[1] + parameters[2]) <= parameters[0]) ||
                ((parameters[0] + parameters[2]) <= parameters[1]))
            {
                check = false;
                message += "Сумма длин двух любых сторон треугольника меньше длины оставшейся стороны!!!\n";
            }

            return check;
        }



        private double Perimeter(params double[] parameters)
        {
            return (parameters[0] + parameters[1] + parameters[2])/2;
        }

        public string isRectangular(params double[] parameters)
        {
            string errorMessage = "";
            bool check = false;

            if (isValidParameters(out errorMessage, parameters) == true)
            {
                if ((parameters[0] == Math.Sqrt(Math.Pow(parameters[1], 2) + Math.Pow(parameters[2], 2))) ||
                    (parameters[1] == Math.Sqrt(Math.Pow(parameters[0], 2) + Math.Pow(parameters[2], 2))) ||
                    (parameters[2] == Math.Sqrt(Math.Pow(parameters[1], 2) + Math.Pow(parameters[0], 2))))
                {
                    check = true;
                }
            }
            else
            {
                throw new Exception(errorMessage);
            }

            string message = "";

            if(check == true)
            {
                message = "Данный треугольник является прямоугольным";
            }
            else
            {
                message = "Данный треугольник не является прямоугольным";
            }

            return message;
        }
    }
}
