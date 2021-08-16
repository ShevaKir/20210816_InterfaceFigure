using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210816_InterfaceFigure
{
    class Square : Figure
    {
        private int _height;

        public Square(int x, int y, int side)
            :base(x, y)
        {
            _height = side;
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }

        public override Point[] GetPoints()
        {
            Point[] points = new Point[4];

            points[0] = new Point(Coordinate.X, Coordinate.Y);
            points[1] = new Point(Coordinate.X + _height, Coordinate.Y);
            points[2] = new Point(Coordinate.X + _height, Coordinate.Y + _height);
            points[3] = new Point(Coordinate.X, Coordinate.Y + _height);

            return points;
        }

        public override void Move(int deltaX, int deltaY)
        {
            Coordinate.X += deltaX;
            Coordinate.Y += deltaY;
        }



        public override double GetArea()
        {
            double area = 0;

            area = _height * _height;

            return area;
        }

        public override double GetPerimetr()
        {
            double perimetr = 0;

            perimetr = 4 * _height;

            return perimetr;
        }


    }
}