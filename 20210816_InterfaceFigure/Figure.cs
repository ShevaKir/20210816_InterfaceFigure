using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210816_InterfaceFigure
{
    abstract class Figure : IGeometrical
    {
        Point _point;

        public Figure(int x, int y)
        {
            _point = new Point(x, y);

        }

        public Point Coordinate
        {
            get
            {
                return _point;
            }
            set
            {
                _point = value;
            }
        }


        public abstract void Move(int deltaX, int deltaY);      //TODO: Перемещение у всех наследников

        public abstract Point[] GetPoints();

        public abstract double GetArea();                       //TODO: Реализация в квадрате и прямоугольнике
        public abstract double GetPerimetr();
    }
}