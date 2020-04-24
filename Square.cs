using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    public class Square
    {
        //вычисляем площадь круга по радиусу
        public double Circle(double r)
        {
            return (Math.PI * r * r);
        }

        //вычисляем площадь треугольника по трем сторонам
        public double Triangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        //проверка является ли треугольник прямоугольным
        public bool IsRectangular(double a, double b, double c)
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                return true;
            }
            else
            {
                return false;
            }                
        }

    }
}
