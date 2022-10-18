using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresSquare.Domain.Abstract
{
    public abstract class Figure
    {
        /// <summary>
        /// Количество параметров, передаваемых для вычисления площади
        /// </summary>
        protected int CountParameters;

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public abstract double Square(params double[] parameters);

        /// <summary>
        /// Проверка на то, чтобы количество передаваемых параметров совпадало с количеством возможных принимаемых параметров
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected bool isCountParameters(params double[] parameters)
        {
            bool check = CountParameters == parameters.Length ? true : false;
            return check;
        }

        /// <summary>
        /// Проверка параметров на валидность
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected abstract bool isValidParameters(out string message, params double[] parameters);

    }
}
