using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresSquare.Domain.Abstract
{
    public interface ITriangleMethod
    {
        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        string isRectangular(params double[] parameters);
    }
}
