using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresSquare.Domain.Abstract
{
    public interface ICreater
    {
        /// <summary>
        /// Создание фигуры
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        Figure CreateFigure(string type);
    }
}
