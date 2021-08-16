using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210816_InterfaceFigure
{
    class Rectangle : Square
    {
        private int _width;

        public Rectangle(int x, int y, int height, int width)
            : base(x, y, height)
        {
            _width = width;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }
        public override Point[] GetPoints()
        {
            Point[] points = new Point[4];

            points[0] = new Point(Coordinate.X, Coordinate.Y);
            points[1] = new Point(Coordinate.X + Height, Coordinate.Y);
            points[2] = new Point(Coordinate.X + Height, Coordinate.Y + _width);
            points[3] = new Point(Coordinate.X, Coordinate.Y + _width);

            return points;
        }

        public override double GetArea()
        {
            double area = 0;

            area = Height * _width;

            return area;
        }

        public override double GetPerimetr()
        {
            double perimetr = 0;

            perimetr = 2 * (Height + _width);

            return perimetr;
        }
    }
}