using FiguresSquare.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresSquare.Domain.Concrete.Shapes
{
    public class Circle : Figure
    {
        public Circle()
        {
            CountParameters = 1;
        }

        public override double Square(params double[] parameters)
        {
            string errorMessage = "";

            if(isValidParameters(out errorMessage, parameters) == true)
                return Math.Round(Math.PI * Math.Pow(parameters[0], 2), 2);
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

            if (parameters[0] < 0)
            {
                check = false;
                message += "Радиус не может быть меньше нуля!!!";
            }

            return check;
        }
    }
}
